using Application.Features.Auth;
using Domain.Services;
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
    public class DeleteCartItemValidator : AbstractValidator<DeleteCartItemCommand>
    {
        public DeleteCartItemValidator()
        {
            RuleFor(command => command.Id).NotEmpty().NotNull();
        }
    }

    public class DeleteCartItemCommand : IRequest
    {
        public Guid Id { get; set; }
    }

    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Unit>
    {
        private readonly ICartItemRepository repository;

        public DeleteCartItemCommandHandler(ICartItemRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteCartItemCommand command, CancellationToken cancellationToken)
        {
            await repository.DeleteByIdAsync(command.Id, cancellationToken);

            return Unit.Value;
        }
    }

}
