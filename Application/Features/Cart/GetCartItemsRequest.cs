using Application.Mapping.Profiles;
using Application.Mapping;
using Application.Services;
using Domain.Repositories;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Features.Cart
{
    public class GetCartItemsRequest : IRequest<GetCartItemsResponse>
    { }

    public class GetCartItemsResponse
    {
        public class CartItemDto
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string? ImgUrl { get; set; }
            public int Amount { get; set; }
        }

        public List<CartItemDto> CartItems { get; set; }
    }

    public class GetCartItemsRequestHandler : IRequestHandler<GetCartItemsRequest, GetCartItemsResponse>
    {
        private readonly ICartRepository repository;
        private readonly IUserService userService;
        private readonly Mapper<CartProfile> mapper = new();

        public GetCartItemsRequestHandler(ICartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<GetCartItemsResponse> Handle(GetCartItemsRequest request, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var cartId = await repository.GetCartIdOfUserAsync(userId, cancellationToken);
            var cartItems = await repository.GetCartItemsAsync(cartId, cancellationToken);

            return new GetCartItemsResponse
            {
                CartItems = mapper.Map<List<CartItem>, List<GetCartItemsResponse.CartItemDto>>(cartItems)
            };
        }
    }

}
