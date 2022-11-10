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
    public class UpdateCartItemAmountValidator : AbstractValidator<UpdateCartItemAmountCommand>
    {
        public UpdateCartItemAmountValidator()
        {
            RuleFor(cartItem => cartItem.Id).NotEmpty().NotNull();
            RuleFor(cartItem => cartItem.Amount).GreaterThanOrEqualTo(1);
        }
    }

    public class UpdateCartItemAmountCommand : IRequest
    { 
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }

    public class UpdateCartItemAmountCommandHandler : IRequestHandler<UpdateCartItemAmountCommand, Unit>
    {
        private readonly ICartItemRepository repository;

        public UpdateCartItemAmountCommandHandler(ICartItemRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateCartItemAmountCommand request, CancellationToken cancellationToken)
        {
            await repository.UpdateCartItemAmountAsync(request.Id, request.Amount, cancellationToken);
            return Unit.Value;
        }
    }

}
