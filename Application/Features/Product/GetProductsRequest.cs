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
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly Mapper<ProductProfile> mapper = new();

        public GetProductsRequestHandler(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
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

            var categoryIds = new HashSet<Guid>();

            if (request.CategoryIds != null)
            {
                foreach (var categoryId in request.CategoryIds)
                {
                    categoryIds.Add(categoryId);

                    var descendantCategoryIds = await categoryRepository.GetDescendantIds(categoryId, cancellationToken);

                    foreach (var descendantCategoryId in descendantCategoryIds)
                    {
                        categoryIds.Add(descendantCategoryId);
                    }
                }

                filter = filter.And(GetCategoryFilter(categoryIds));
            }

            var pagedProducts = await productRepository.GetPagedAsync(filter, request.OrderBy, request.Page, request.Count, cancellationToken);

            return mapper.Map<PagedList<Domain.Models.Product>, GetProductsResponse>(pagedProducts);
        }

        private static ExpressionStarter<Domain.Models.Product> GetCategoryFilter(HashSet<Guid> categoryIds)
        {
            var categoryFilter = PredicateBuilder.New<Domain.Models.Product>(true);

            foreach (var categoryId in categoryIds)
            {
                categoryFilter = categoryFilter.Or(p => p.CategoryId == categoryId);
            }

            return categoryFilter;
        }
    }
}
