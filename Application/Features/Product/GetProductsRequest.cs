using Application.Mapping;
using Application.Mapping.Profiles;
using Domain.Models;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product
{
    public class GetProductsRequest: IRequest<GetProductsResponse>
    { }

    public class GetProductsResponse
    {
        public class ProductDto
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string? ImgUrl { get; set; }
        }
        
        public ProductDto[] Products { get; set; }

        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalItems { get; set; }
    }

    public class GetProductsRequestHandler : IRequestHandler<GetProductsRequest, GetProductsResponse>
    {
        private readonly IProductRepository repository;
        private readonly Mapper<ProductProfile> mapper = new();

        public GetProductsRequestHandler(IProductRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetProductsResponse> Handle(GetProductsRequest request, CancellationToken cancellationToken)
        {
            var products = await repository.GetByQueryAsync(cancellationToken);

            return new GetProductsResponse
            {
                Products = mapper.Map<List<Domain.Models.Product>, GetProductsResponse.ProductDto[]>(products)
            };
        }
    }
}
