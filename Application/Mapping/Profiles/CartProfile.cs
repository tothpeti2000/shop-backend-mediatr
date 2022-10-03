using Application.Features.Cart;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class CartProfile: Profile
    {
        public CartProfile()
        {
            CreateMap<AddItemToCartCommand, CartItem>();
            CreateMap<CartItem, GetCartItemsResponse.CartItemDto>()
                .ForMember(dto => dto.Name, options => options.MapFrom(cartItem => cartItem.Product.Name))
                .ForMember(dto => dto.Price, options => options.MapFrom(cartItem => cartItem.Product.Price))
                .ForMember(dto => dto.ImgUrl, options => options.MapFrom(cartItem => cartItem.Product.ImgUrl));
        }
    }
}
