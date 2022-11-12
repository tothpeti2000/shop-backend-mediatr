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
        }
    }
}
