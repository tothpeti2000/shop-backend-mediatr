using API;
using API.Hubs;
using API.Services;
using Application.Hubs;
using Application.Pipeline;
using Application.Services;
using Domain.Services;
using DAL;
using DAL.Exceptions;
using DAL.Repositories;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hellang.Middleware.ProblemDetails;
using Hellang.Middleware.ProblemDetails.Mvc;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// DB
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString));

// Identity
builder.Services
    .AddIdentityCore<User>(options => 
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.User.RequireUniqueEmail = true;
    })
    .AddEntityFrameworkStores<ShopDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<User>>(TokenOptions.DefaultProvider);

//Problem Details
builder.Services
    .AddProblemDetails(options =>
    {
        options.MapToStatusCode<EntityNotFoundException>(StatusCodes.Status404NotFound);
        options.MapToStatusCode<ValidationException>(StatusCodes.Status400BadRequest);
        options.MapToStatusCode<InvalidOperationException>(StatusCodes.Status400BadRequest);
        options.MapToStatusCode<NotImplementedException>(StatusCodes.Status501NotImplemented);
        options.MapToStatusCode<HttpRequestException>(StatusCodes.Status503ServiceUnavailable);
        options.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);
    })
    .AddControllers()
    .AddProblemDetailsConventions()
    .AddJsonOptions(x =>
    {
        x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

builder.Services
    .AddControllers()
    .AddFluentValidation(options =>
{
    options.RegisterValidatorsFromAssembly(Assembly.Load("Application"));
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    var Key = Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]);

    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Key)
    };

    // Without this config section, the JWT authentication handler wouldn't be able to read
    // the access token from the query string when a WS request comes in
    // See more at https://learn.microsoft.com/en-us/aspnet/core/signalr/authn-and-authz?view=aspnetcore-7.0&viewFallbackFrom=aspnetcore-2.2
    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            var token = context.Request.Query["access_token"];
            var path = context.HttpContext.Request.Path;

            if (!string.IsNullOrEmpty(token) && path.StartsWithSegments("/hubs/shared-cart"))
            {
                context.Token = token;
            }

            return Task.CompletedTask;
        }
    };
});

// Swagger
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Shop API", Version = "v1" });
    option.CustomOperationIds(e => e.ActionDescriptor.RouteValues["action"]);

    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Enter a valid JWT token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });

    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// CORS
var FrontendOrigins = "_frontendOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: FrontendOrigins,
        policy =>
        {
            policy
                .WithOrigins(builder.Configuration["Frontend:BaseUrl"])
                .AllowAnyMethod()
                .AllowCredentials()
                .AllowAnyHeader();
        });
});

// MediatR
builder.Services.AddMediatR(Assembly.Load("Application"));
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(SaveBehavior<,>));

// SignalR
builder.Services.AddSignalR();
builder.Services.AddTransient<ISharedCartHub, SharedCartHubAdapter>();

// Repositories, Services
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITokenGenerator, TokenGenerator>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IPaymentService, MockPaymentService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IPasscodeGenerator, PasscodeGenerator>();
builder.Services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartItemRepository, CartItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ISharedCartRepository, SharedCartRepository>();
builder.Services.AddScoped<ISharedCartItemRepository, SharedCartItemRepository>();
builder.Services.AddScoped<ISharedOrderRepository, SharedOrderRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<ShopDbContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(FrontendOrigins);

app.UseProblemDetails();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<SharedCartHub>("/hubs/shared-cart");

app.Run();
