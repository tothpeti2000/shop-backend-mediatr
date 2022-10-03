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
        }
    }
}
