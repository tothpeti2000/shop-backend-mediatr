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
    public class GetSharedCartItemsValidator : AbstractValidator<GetSharedCartItemsRequest>
    {
        public GetSharedCartItemsValidator()
        {
            RuleFor(request => request.Id).NotEmpty().NotNull();
        }
    }

    public class GetSharedCartItemsRequest : IRequest<GetSharedCartItemsResponse>
    {
        public Guid Id { get; set; }
    }

    public class GetSharedCartItemsResponse
    {
        public class SharedCartItemDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public string? ImgUrl { get; set; }
            public int Amount { get; set; }
        }

        public List<SharedCartItemDto> SharedCartItems { get; set; }
    }

    public class GetSharedCartItemsRequestHandler : IRequestHandler<GetSharedCartItemsRequest, GetSharedCartItemsResponse>
    {
        private readonly ISharedCartRepository repository;
        private readonly Mapper<SharedCartProfile> mapper = new();

        public GetSharedCartItemsRequestHandler(ISharedCartRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetSharedCartItemsResponse> Handle(GetSharedCartItemsRequest request, CancellationToken cancellationToken)
        {
            var cartItems = await repository.GetCartItemsAsync(request.Id, cancellationToken);

            return new GetSharedCartItemsResponse
            {
                SharedCartItems = mapper.Map<List<SharedCartItem>, List<GetSharedCartItemsResponse.SharedCartItemDto>>(cartItems)
            };
        }
    }

}
