using Application.Services;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Cart
{
    public class ClearCartCommand : IRequest
    { }

    public class ClearCartCommandCommandHandler : IRequestHandler<ClearCartCommand, Unit>
    {
        private readonly ICartRepository repository;
        private readonly IUserService userService;

        public ClearCartCommandCommandHandler(ICartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<Unit> Handle(ClearCartCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cart = await repository.GetCartOfUserAsync(userId, cancellationToken);

            cart.CartItems.Clear();

            return Unit.Value;
        }
    }

}
