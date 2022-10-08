using Application.Mapping;
using Application.Mapping.Profiles;
using Domain.Paging;
using Domain.QueryStringParams;
using Domain.Repositories;
using FluentValidation;
using LinqKit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product
{
    public class GetProductsRequest: QueryStringParams, IRequest<GetProductsResponse>
    {
        public string? Name { get; set; }
        public double? FromPrice { get; set; }
        public double? ToPrice { get; set; }
        public List<Guid>? CategoryIds { get; set; }
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

            if (request.FromPrice != null)
            {
                filter = filter.And(p => p.Price >= request.FromPrice);
            }

            if (request.ToPrice != null)
            {
                filter = filter.And(p => p.Price <= request.ToPrice);
            }

            filter = filter.And(GetCategoryFilter(request.CategoryIds));

            var pagedProducts = await repository.GetPagedAsync(filter, request.OrderBy, request.Page, request.Count, cancellationToken);

            return mapper.Map<PagedList<Domain.Models.Product>, GetProductsResponse>(pagedProducts);
        }

        private static ExpressionStarter<Domain.Models.Product> GetCategoryFilter(List<Guid>? categoryIds)
        {
            var categoryFilter = PredicateBuilder.New<Domain.Models.Product>(true);


            if (categoryIds != null)
            {
                foreach (var categoryId in categoryIds)
                {
                    categoryFilter = categoryFilter.Or(p => p.CategoryId == categoryId || p.Category.ParentCategoryId == categoryId);
                }
            }

            return categoryFilter;
        }
    }
}
