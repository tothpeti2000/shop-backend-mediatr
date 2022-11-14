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

        public DeleteSharedCartItemCommandHandler(ISharedCartItemRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteSharedCartItemCommand command, CancellationToken cancellationToken)
        {
            await repository.DeleteByIdAsync(command.CartItemId, cancellationToken);

            return Unit.Value;
        }
    }

}
