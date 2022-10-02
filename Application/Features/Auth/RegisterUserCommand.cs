using Domain.Models;
using Domain.Repositories;
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
    public class RegisterUserValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserValidator()
        {
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
            RuleFor(u => u.Password).NotEmpty();
        }
    }

    public class RegisterUserCommand: IRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterUserCommandHandler: IRequestHandler<RegisterUserCommand, Unit>
    {
        private readonly UserManager<User> userManager;
        private readonly ICartRepository cartRepository;

        public RegisterUserCommandHandler(UserManager<User> userManager, ICartRepository cartRepository)
        {
            this.userManager = userManager;
            this.cartRepository = cartRepository;
        }

        public async Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                UserName = request.UserName,
                Email = request.Email,
            };

            var result = await userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description}\n";
                }

                throw new InvalidOperationException(errors);
            }

            await cartRepository.CreateCartForUserAsync(user.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
