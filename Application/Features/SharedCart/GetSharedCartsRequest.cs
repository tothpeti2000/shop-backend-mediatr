using Application.Mapping.Profiles;
using Application.Mapping;
using Application.Services;
using Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Features.SharedCart
{
    public class GetSharedCartsRequest : IRequest<GetSharedCartsResponse>
    { }

    public class GetSharedCartsResponse
    { 
        public class SharedCartDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string? Description { get; set; }
            public string Passcode { get; set; }
            public List<string> UserNames { get; set; }
        }

        public List<SharedCartDto> Carts { get; set; }
    }

    public class GetSharedCartsRequestHandler : IRequestHandler<GetSharedCartsRequest, GetSharedCartsResponse>
    {
        private readonly ISharedCartRepository repository;
        private readonly IUserService userService;
        private readonly Mapper<SharedCartProfile> mapper = new();

        public GetSharedCartsRequestHandler(ISharedCartRepository repository, IUserService userService)
        {
            this.repository = repository;
            this.userService = userService;
        }

        public async Task<GetSharedCartsResponse> Handle(GetSharedCartsRequest request, CancellationToken cancellationToken)
        {
            var userId = userService.GetUserIdFromContext();
            var carts = await repository.GetCartsOfUserAsync(userId, cancellationToken);

            return new GetSharedCartsResponse
            {
                Carts = mapper.Map<List<Domain.Models.SharedCart>, List<GetSharedCartsResponse.SharedCartDto>>(carts)
            };
        }
    }

}
