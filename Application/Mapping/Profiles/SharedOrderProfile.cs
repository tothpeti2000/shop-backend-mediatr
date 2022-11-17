using Application.Features.Order;
using Application.Features.SharedOrder;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class SharedOrderProfile: Profile
    {
        public SharedOrderProfile()
        {
            CreateMap<PlaceSharedOrderCommand, SharedOrder>()
                .ForMember(order => order.FirstName, options => options.MapFrom(command => command.CustomerData.FirstName))
                .ForMember(order => order.LastName, options => options.MapFrom(command => command.CustomerData.LastName))
                .ForMember(order => order.Phone, options => options.MapFrom(command => command.CustomerData.Phone))
                .ForMember(order => order.ZipCode, options => options.MapFrom(command => command.DeliveryData.ZipCode))
                .ForMember(order => order.City, options => options.MapFrom(command => command.DeliveryData.City))
                .ForMember(order => order.Address, options => options.MapFrom(command => command.DeliveryData.Address));
        }
    }
}
