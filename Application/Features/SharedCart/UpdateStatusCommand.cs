using Application.Hubs;
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
    public class UpdateStatusValidator : AbstractValidator<UpdateStatusCommand>
    {
        public UpdateStatusValidator()
        {
            RuleFor(command => command.SharedCartId).NotEmpty().NotNull();
            RuleFor(command => command.Status).NotNull().IsInEnum();
        }
    }

    public class UpdateStatusCommand : IRequest
    {
        public Guid SharedCartId { get; set; }
        public SharedCartStatus Status { get; set; }
    }

    public class UpdateStatusCommandHandler : IRequestHandler<UpdateStatusCommand, Unit>
    {
        private readonly ISharedCartRepository repository;
        private readonly IUnitOfWork uow;
        private readonly ISharedCartHub sharedCartHub;

        public UpdateStatusCommandHandler(
            ISharedCartRepository repository, 
            IUnitOfWork uow,
            ISharedCartHub sharedCartHub)
        {
            this.repository = repository;
            this.uow = uow;
            this.sharedCartHub = sharedCartHub;
        }

        public async Task<Unit> Handle(UpdateStatusCommand command, CancellationToken cancellationToken)
        {
            var cart = await repository.GetByIdAsync(command.SharedCartId, cancellationToken);

            // If the cart is in completed state already, we don't want to modify it
            if (cart.Status == SharedCartStatus.Completed)
            {
                return Unit.Value;
            }

            cart.Status = command.Status;
            await uow.SaveChangesAsync();

            switch (command.Status)
            {
                case SharedCartStatus.Active:
                    await sharedCartHub.CheckoutAborted(command.SharedCartId);
                    break;
                case SharedCartStatus.CheckoutInProgress:
                    await sharedCartHub.CheckoutStarted(command.SharedCartId);
                    break;
                case SharedCartStatus.Completed:
                    await sharedCartHub.OrderPlaced(command.SharedCartId);
                    break;
            }

            return Unit.Value;
        }
    }

}
