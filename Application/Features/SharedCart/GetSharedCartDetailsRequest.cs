using Application.Mapping;
using Application.Mapping.Profiles;
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
    public class GetSharedCartDetailsValidator : AbstractValidator<GetSharedCartDetailsRequest>
    {
        public GetSharedCartDetailsValidator()
        {
            RuleFor(request => request.Id).NotEmpty().NotNull();
        }
    }

    public class GetSharedCartDetailsRequest : IRequest<GetSharedCartDetailsResponse>
    {
        public Guid Id { get; set; }
    }

    public class GetSharedCartDetailsResponse
    {
        public class SharedCartItemDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string? ImgUrl { get; set; }
            public int Amount { get; set; }
        }

        public string CartName { get; set; }
        public SharedCartStatus Status { get; set; }
        public List<SharedCartItemDto> SharedCartItems { get; set; }
    }

    public class GetSharedCartDetailsRequestHandler : IRequestHandler<GetSharedCartDetailsRequest, GetSharedCartDetailsResponse>
    {
        private readonly ISharedCartRepository repository;
        private readonly Mapper<SharedCartProfile> mapper = new();

        public GetSharedCartDetailsRequestHandler(ISharedCartRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetSharedCartDetailsResponse> Handle(GetSharedCartDetailsRequest request, CancellationToken cancellationToken)
        {
            var cart = await repository.GetCartByIdAsync(request.Id, cancellationToken);

            return new GetSharedCartDetailsResponse
            {
                CartName = cart.Name,
                Status = cart.Status,
                SharedCartItems = mapper.Map<List<SharedCartItem>, List<GetSharedCartDetailsResponse.SharedCartItemDto>>(cart.CartItems)
            };
        }
    }

}
