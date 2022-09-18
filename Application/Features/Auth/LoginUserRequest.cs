using Application.Services;
using Domain.Models;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth
{
    public class LoginUserValidator : AbstractValidator<LoginUserRequest>
    {
        public LoginUserValidator()
        {
            RuleFor(credentials => credentials.Email).NotEmpty().EmailAddress();
            RuleFor(credentials => credentials.Password).NotEmpty();
        }
    }

    public class LoginUserRequest: IRequest<LoginUserResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginUserResponse
    {
        public string Token { get; set; }
    }

    public class LoginUserRequestHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly ITokenGenerator tokenGenerator;

        public LoginUserRequestHandler(UserManager<User> userManager, ITokenGenerator tokenGenerator)
        {
            this.userManager = userManager;
            this.tokenGenerator = tokenGenerator;
        }

        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByEmailAsync(request.Email) ?? throw new ArgumentException("User not found by the given email address");
            var passwordValid = await userManager.CheckPasswordAsync(user, request.Password);

            if (!passwordValid)
            {
                throw new InvalidOperationException("Wrong password");
            }

            return new LoginUserResponse() {
                Token = tokenGenerator.GenerateToken(user.Id) 
            };
        }
    }
}
