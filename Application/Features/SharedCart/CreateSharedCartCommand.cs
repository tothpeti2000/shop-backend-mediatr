using Application.Mapping.Profiles;
using Application.Mapping;
using Application.Services;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using DAL.Repositories;

namespace Application.Features.SharedCart
{
    public class CreateSharedCartValidator : AbstractValidator<CreateSharedCartCommand>
    {
        public CreateSharedCartValidator()
        {
            RuleFor(cart => cart.Name).NotEmpty().NotNull();
        }
    }

    public class CreateSharedCartCommand : IRequest<CreateSharedCartResponse>
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class CreateSharedCartResponse
    {
        public Guid Id { get; set; }
    }

    public class CreateSharedCartCommandHandler : IRequestHandler<CreateSharedCartCommand, CreateSharedCartResponse>
    {
        private readonly ISharedCartRepository repository;
        private readonly IUserService userService;
        private readonly IPasscodeGenerator passcodeGenerator;

        public CreateSharedCartCommandHandler(ISharedCartRepository repository, IUserService userService, IPasscodeGenerator passcodeGenerator)
        {
            this.repository = repository;
            this.userService = userService;
            this.passcodeGenerator = passcodeGenerator;
        }

        public async Task<CreateSharedCartResponse> Handle(CreateSharedCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);
            var passcode = passcodeGenerator.GeneratePasscode(8);

            var cartPasscodes = await repository.GetAllPasscodesAsync(cancellationToken);

            while (cartPasscodes.Contains(passcode))
            {
                passcode = passcodeGenerator.GeneratePasscode(8);
            }

            var cart = new Domain.Models.SharedCart
            {
                Name = command.Name,
                Description = command.Description,
                Passcode = passcode,
                Users = new List<User> { user },
            };

            await repository.AddAsync(cart, cancellationToken);

            return new CreateSharedCartResponse
            {
                Id = cart.Id
            };
        }
    }

}
