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

namespace Application.Features.SharedCart
{
    public class CreateSharedCartValidator : AbstractValidator<CreateSharedCartCommand>
    {
        public CreateSharedCartValidator()
        {
            RuleFor(cart => cart.Name).NotEmpty().NotNull();
        }
    }

    public class CreateSharedCartCommand : IRequest
    {
        public string Name { get; set; }
        public string? Description { get; set; }
    }

    public class CreateSharedCartCommandHandler : IRequestHandler<CreateSharedCartCommand, Unit>
    {
        private readonly ISharedCartRepository repository;
        private readonly IUserService userService;
        private readonly UserManager<User> userManager;

        public CreateSharedCartCommandHandler(ISharedCartRepository repository, IUserService userService, UserManager<User> userManager)
        {
            this.repository = repository;
            this.userService = userService;
            this.userManager = userManager;
        }

        public async Task<Unit> Handle(CreateSharedCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userManager.FindByIdAsync(userId.ToString());

            var cart = new Domain.Models.SharedCart
            {
                Name = command.Name,
                Description = command.Description,
                Users = new List<User> { user },
            };

            await repository.AddAsync(cart, cancellationToken);

            return Unit.Value;
        }
    }

}
