using Application.Features.SharedCart;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class SharedCartProfile: Profile
    {
        public SharedCartProfile()
        {
            CreateMap<SharedCart, GetSharedCartsResponse.SharedCartDto>()
                .ForMember(dto => dto.UserNames, options => options.MapFrom(cart => cart.Users.Select(u => u.Name)));

            CreateMap<SharedCart, JoinSharedCartResponse>();
            CreateMap<AddItemToSharedCartCommand, SharedCartItem>();

            CreateMap<SharedCartItem, GetSharedCartItemsResponse.SharedCartItemDto>()
                .ForMember(dto => dto.Name, options => options.MapFrom(cartItem => cartItem.Product.Name))
                .ForMember(dto => dto.Price, options => options.MapFrom(cartItem => cartItem.Product.Price))
                .ForMember(dto => dto.ImgUrl, options => options.MapFrom(cartItem => cartItem.Product.ImgUrl));
        }
    }
}
