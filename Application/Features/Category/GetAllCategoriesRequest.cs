using Application.Mapping.Profiles;
using Application.Mapping;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category
{
    public class GetAllCategoriesRequest : IRequest<GetAllCategoriesResponse>
    { }

    public class GetAllCategoriesResponse
    {
        public class CategoryDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public Guid? ParentCategoryId { get; set; }
        }

        public List<CategoryDto> Categories { get; set; }
    }

    public class GetCategoriesRequestHandler : IRequestHandler<GetAllCategoriesRequest, GetAllCategoriesResponse>
    {
        private readonly ICategoryRepository repository;
        private readonly Mapper<CategoryProfile> mapper = new();

        public GetCategoriesRequestHandler(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetAllCategoriesResponse> Handle(GetAllCategoriesRequest request, CancellationToken cancellationToken)
        {
            var categories = await repository.GetAllAsync(cancellationToken);

            return new GetAllCategoriesResponse
            {
                Categories = mapper.Map<List<Domain.Models.Category>, List<GetAllCategoriesResponse.CategoryDto>>(categories)
            };
        }
    }

}
