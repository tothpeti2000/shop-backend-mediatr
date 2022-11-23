using Domain.Services;
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
            RuleFor(u => u.Name).NotEmpty().NotNull();
            RuleFor(u => u.UserName).NotEmpty().NotNull();
            RuleFor(u => u.Email).NotEmpty().NotNull().EmailAddress();
            RuleFor(u => u.Password).NotEmpty().NotNull();
        }
    }

    public class RegisterUserCommand: IRequest
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class RegisterUserCommandHandler: IRequestHandler<RegisterUserCommand, Unit>
    {
        private readonly IUserService userService;
        private readonly ICartRepository cartRepository;

        public RegisterUserCommandHandler(IUserService userService, ICartRepository cartRepository)
        {
            this.userService = userService;
            this.cartRepository = cartRepository;
        }

        public async Task<Unit> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Name = command.Name,
                UserName = command.UserName,
                Email = command.Email,
            };

            await userService.CreateUserAsync(user, command.Password);
            await cartRepository.CreateCartForUserAsync(user.Id, cancellationToken);

            return Unit.Value;
        }
    }
}
