using Application.Features.Product;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Domain.Models.Product, GetProductsResponse.ProductDto>();
            CreateMap<Domain.Models.Product, GetProductByIdResponse>();
        }
    }
}
