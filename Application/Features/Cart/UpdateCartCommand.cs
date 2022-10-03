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
    public class UpdateCartCommand : IRequest
    { 
        public List<AddItemToCartCommand> CartItems { get; set; }
    }

    public class UpdateCartCommandHandler : IRequestHandler<UpdateCartCommand, Unit>
    {
        private readonly ICartRepository repository;
        private readonly IUserService userService;
        private readonly Mapper<CartProfile> mapper = new();

        public UpdateCartCommandHandler(ICartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<Unit> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cartId = await repository.GetCartIdOfUserAsync(userId, cancellationToken);
            var cartItems = mapper.Map<List<AddItemToCartCommand>, List<CartItem>>(request.CartItems);

            await repository.UpdateCartItemsAsync(cartId, cartItems, cancellationToken);

            return Unit.Value;
        }
    }

}
