using Domain.Services;
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
            RuleFor(credentials => credentials.UserName).NotEmpty().NotNull();
            RuleFor(credentials => credentials.Password).NotEmpty().NotNull();
        }
    }

    public class LoginUserRequest: IRequest<LoginUserResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginUserResponse
    {
        public string Token { get; set; }
        public string Name { get; set; }
    }

    public class LoginUserRequestHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly IUserService userService;

        public LoginUserRequestHandler(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            var user = await userService.GetByNameAsync(request.UserName);

            if (user == null)
            {
                throw new InvalidOperationException("User not found by the given username");
            }

            var passwordValid = await userService.CheckPasswordAsync(user, request.Password);

            if (!passwordValid)
            {
                throw new InvalidOperationException("Wrong password");
            }

            return new LoginUserResponse() {
                Token = userService.GenerateTokenForUser(user.Id),
                Name = user.Name
            };
        }
    }
}
