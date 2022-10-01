using Application.Mapping;
using Application.Mapping.Profiles;
using Domain.Enums;
using Domain.Paging;
using Domain.Repositories;
using LinqKit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product
{
    public class GetProductsRequest: IRequest<GetProductsResponse>
    {
        public string? Name { get; set; }
        public PagingOptions? PagingOptions { get; set; }
        //public double FromPrice { get; set; }
        //public double ToPrice { get; set; }
    }

    public class GetProductsResponse: PagedList<GetProductsResponse.ProductDto>
    {
        public class ProductDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public string? ImgUrl { get; set; }
        }
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
            var filter = PredicateBuilder.New<Domain.Models.Product>(true);

            if (!string.IsNullOrWhiteSpace(request.Name))
            {
                filter = filter.And(p => p.Name.ToUpper().Contains(request.Name.ToUpper()));
            }

            var pagingOptions = request.PagingOptions ?? new PagingOptions();

            var pagedProducts = await repository.GetAsync(filter, pagingOptions, cancellationToken);

            return mapper.Map<PagedList<Domain.Models.Product>, GetProductsResponse>(pagedProducts);
        }
    }
}
