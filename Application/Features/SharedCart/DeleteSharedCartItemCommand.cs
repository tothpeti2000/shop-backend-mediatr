using Application.Hubs;
using Application.Services;
using Domain.Interfaces;
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
    public class DeleteSharedCartItemValidator : AbstractValidator<DeleteSharedCartItemCommand>
    {
        public DeleteSharedCartItemValidator()
        {
            RuleFor(command => command.CartItemId).NotEmpty().NotNull();
        }
    }

    public class DeleteSharedCartItemCommand : IRequest
    {
        public Guid CartItemId { get; set; }
    }

    public class DeleteSharedCartItemCommandHandler : IRequestHandler<DeleteSharedCartItemCommand, Unit>
    {
        private readonly ISharedCartItemRepository repository;
        private readonly IUserService userService;
        private readonly IUnitOfWork uow;
        private readonly ISharedCartHub sharedCartHub;

        public DeleteSharedCartItemCommandHandler(
            ISharedCartItemRepository repository, 
            IUserService userService,
            IUnitOfWork uow,
            ISharedCartHub sharedCartHub)
        {
            this.repository = repository;
            this.userService = userService;
            this.uow = uow;
            this.sharedCartHub = sharedCartHub;
        }

        public async Task<Unit> Handle(DeleteSharedCartItemCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);
            var cartItem = await repository.GetItemByIdAsync(command.CartItemId, cancellationToken);

            await repository.DeleteByIdAsync(command.CartItemId, cancellationToken);
            await uow.SaveChangesAsync();

            var actionDetails = new ActionDetails
            {
                CartId = cartItem.SharedCartId,
                Message = $"{user.Name} deleted {cartItem.Product.Name}"
            };

            await sharedCartHub.ItemDeleted(actionDetails);

            return Unit.Value;
        }
    }

}
