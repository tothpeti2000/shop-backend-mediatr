using Application.Mapping;
using Application.Mapping.Profiles;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category
{
    public class GetTopCategoriesRequest : IRequest<GetTopCategoriesResponse>
    { }

    public class GetTopCategoriesResponse
    { 
        public class TopCategory
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string ImgUrl { get; set; }
        }

        public List<TopCategory> TopCategories { get; set; }
    }

    public class GetTopCategoriesRequestHandler : IRequestHandler<GetTopCategoriesRequest, GetTopCategoriesResponse>
    {
        private readonly ICategoryRepository repository;
        private readonly Mapper<CategoryProfile> mapper = new();

        public GetTopCategoriesRequestHandler(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<GetTopCategoriesResponse> Handle(GetTopCategoriesRequest request, CancellationToken cancellationToken)
        {
            var topCategories = await repository.GetTopCategoriesAsync(cancellationToken);

            return new GetTopCategoriesResponse
            {
                TopCategories = mapper.Map<List<Domain.Models.Category>, List<GetTopCategoriesResponse.TopCategory>>(topCategories)
            };
        }
    }

}
