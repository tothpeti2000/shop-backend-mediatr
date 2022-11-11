using Application.Features.Auth;
using Application.Mapping;
using Application.Mapping.Profiles;
using Application.Services;
using Domain.Models;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cart
{
    public class AddItemToCartValidator : AbstractValidator<AddItemToCartCommand>
    {
        public AddItemToCartValidator()
        {
            RuleFor(command => command.ProductId).NotEmpty().NotNull();
        }
    }

    public class AddItemToCartCommand : IRequest
    {
        public Guid ProductId { get; set; }
    }

    public class AddItemToCartCommandHandler : IRequestHandler<AddItemToCartCommand, Unit>
    {
        private readonly ICartRepository repository;
        private readonly IUserService userService;
        private readonly Mapper<CartProfile> mapper = new();

        public AddItemToCartCommandHandler(ICartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<Unit> Handle(AddItemToCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cart = await repository.GetCartOfUserAsync(userId, cancellationToken);

            var cartItem = cart.CartItems
                .FirstOrDefault(ci => ci.ProductId == command.ProductId);

            if (cartItem == null)
            {
                cartItem = mapper.Map<AddItemToCartCommand, CartItem>(command);

                cart.CartItems
                    .Add(cartItem);
            }

            cartItem.Amount++;

            return Unit.Value;
        }
    }

}
