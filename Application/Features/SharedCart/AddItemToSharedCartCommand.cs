using Application.Hubs;
using Application.Mapping;
using Application.Mapping.Profiles;
using Application.Services;
using Domain.Interfaces;
using Domain.Models;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.SharedCart
{
    public class AddItemToSharedCartValidator : AbstractValidator<AddItemToSharedCartCommand>
    {
        public AddItemToSharedCartValidator()
        {
            RuleFor(command => command.CartId).NotEmpty().NotNull();
            RuleFor(command => command.ProductId).NotEmpty().NotNull();
        }
    }

    public class AddItemToSharedCartCommand : IRequest
    {
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
    }

    public class AddItemToSharedCartCommandHandler : IRequestHandler<AddItemToSharedCartCommand, Unit>
    {
        private readonly ISharedCartRepository sharedCartRepository;
        private readonly IProductRepository productRepository;
        private readonly IUserService userService;
        private readonly IUnitOfWork uow;
        private readonly ISharedCartHub sharedCartHub;
        private readonly Mapper<SharedCartProfile> mapper = new();

        public AddItemToSharedCartCommandHandler(
            ISharedCartRepository sharedCartRepository, 
            IProductRepository productRepository,
            IUserService userService,
            IUnitOfWork uow, 
            ISharedCartHub sharedCartHub)
        {
            this.sharedCartRepository = sharedCartRepository;
            this.productRepository = productRepository;
            this.userService = userService;
            this.uow = uow;
            this.sharedCartHub = sharedCartHub;
        }

        public async Task<Unit> Handle(AddItemToSharedCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);
            var cart = await sharedCartRepository.GetCartByIdAsync(command.CartId, cancellationToken);
            var product = await productRepository.GetByIdAsync(command.ProductId, cancellationToken);

            var cartItem = cart.CartItems
                .FirstOrDefault(ci => ci.ProductId == command.ProductId);

            var message = $"{user.Name} modified the amount of {product.Name}";

            if (cartItem == null)
            {
                cartItem = mapper.Map<AddItemToSharedCartCommand, SharedCartItem>(command);
                cart.CartItems.Add(cartItem);

                message = $"{user.Name} added {product.Name}";
            }

            cartItem.Amount++;
            await uow.SaveChangesAsync();

            var actionDetails = new ActionDetails
            {
                Message = message,
                CartId = command.CartId
            };

            await sharedCartHub.ItemAdded(actionDetails, command.CartId);

            return Unit.Value;
        }
    }

}
