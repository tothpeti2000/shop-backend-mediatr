using Application.Features.SharedCart;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class SharedCartsController : ControllerBase
    {
        private readonly IMediator mediator;

        public SharedCartsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<CreateSharedCartResponse> CreateSharedCart(CreateSharedCartCommand command, CancellationToken cancellationToken)
        {
            return await mediator.Send(command, cancellationToken);
        }

        [HttpGet]
        public async Task<GetSharedCartsResponse> GetSharedCarts(CancellationToken cancellationToken)
        {
            return await mediator.Send(new GetSharedCartsRequest(), cancellationToken);
        }

        [HttpPost("join")]
        public async Task<JoinSharedCartResponse> JoinSharedCart(JoinSharedCartCommand command, CancellationToken cancellationToken)
        {
            return await mediator.Send(command, cancellationToken);
        }

        [HttpPost("add-item")]
        public async Task AddItemToSharedCart(AddItemToSharedCartCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
        }
    }
}
