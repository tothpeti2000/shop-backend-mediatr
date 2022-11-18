using Application.Hubs;
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
    public class UpdateSharedCartItemAmountValidator : AbstractValidator<UpdateSharedCartItemAmountCommand>
    {
        public UpdateSharedCartItemAmountValidator()
        {
            RuleFor(cartItem => cartItem.Id).NotEmpty().NotNull();
            RuleFor(cartItem => cartItem.Amount).GreaterThanOrEqualTo(1);
        }
    }

    public class UpdateSharedCartItemAmountCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }

    public class UpdateSharedCartItemCommandHandler : IRequestHandler<UpdateSharedCartItemAmountCommand, Unit>
    {
        private readonly ISharedCartItemRepository repository;
        private readonly IUserService userService;
        private readonly IUnitOfWork uow;
        private readonly ISharedCartHub sharedCartHub;

        public UpdateSharedCartItemCommandHandler(
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

        public async Task<Unit> Handle(UpdateSharedCartItemAmountCommand command, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var user = await userService.GetByIdAsync(userId);
            var cartItem = await repository.GetItemByIdAsync(command.Id, cancellationToken);

            cartItem.Amount = command.Amount;
            await uow.SaveChangesAsync();

            var actionDetails = new ActionDetails
            {
                CartId = cartItem.SharedCartId,
                Message = $"{user.Name} modified the amount of {cartItem.Product.Name}"
            };

            await sharedCartHub.ItemAmountUpdated(actionDetails);

            return Unit.Value;
        }
    }

}
