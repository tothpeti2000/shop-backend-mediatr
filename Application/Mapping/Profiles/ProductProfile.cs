using Application.Features.Product;
using AutoMapper;
using Domain.Paging;
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
            CreateMap<PagedList<Domain.Models.Product>, GetProductsResponse>();
            CreateMap<Domain.Models.Product, GetProductByIdResponse>();
        }
    }
}
