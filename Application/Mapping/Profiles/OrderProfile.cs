using Application.Features.Order;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class OrderProfile: Profile
    {
        public OrderProfile()
        {
            CreateMap<PlaceOrderCommand, Order>()
                .ForMember(order => order.FirstName, options => options.MapFrom(command => command.CustomerData.FirstName))
                .ForMember(order => order.LastName, options => options.MapFrom(command => command.CustomerData.LastName))
                .ForMember(order => order.Phone, options => options.MapFrom(command => command.CustomerData.Phone))
                .ForMember(order => order.ZipCode, options => options.MapFrom(command => command.DeliveryData.ZipCode))
                .ForMember(order => order.City, options => options.MapFrom(command => command.DeliveryData.City))
                .ForMember(order => order.Address, options => options.MapFrom(command => command.DeliveryData.Address));
        }
    }
}
