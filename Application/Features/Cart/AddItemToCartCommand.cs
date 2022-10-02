using Application.Services;
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
            RuleFor(item => item.Amount).GreaterThanOrEqualTo(1);
        }
    }

    public class AddItemToCartCommand : IRequest
    {
        public Guid ProductId { get; set; }
        public int Amount { get; set; }
    }

    public class AddItemToCartCommandHandler : IRequestHandler<AddItemToCartCommand, Unit>
    {
        private readonly ICartRepository repository;
        private readonly IUserService userService;

        public AddItemToCartCommandHandler(ICartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<Unit> Handle(AddItemToCartCommand request, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cartId = await repository.GetCartIdOfUserAsync(userId, cancellationToken);

            await repository.AddItemToCartAsync(request.ProductId, request.Amount, cartId, cancellationToken);

            return Unit.Value;
        }
    }

}
