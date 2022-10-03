using Application.Features.Cart;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IMediator mediator;

        public CartsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("add-item")]
        [Authorize]
        public async Task AddItemToCart(AddItemToCartCommand command, CancellationToken cancellationToken)
        {   
            await mediator.Send(command, cancellationToken);
        }

        [HttpPut("update")]
        [Authorize]
        public async Task UpdateCart(UpdateCartCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
        }

        [HttpGet("items")]
        [Authorize]
        public async Task<GetCartItemsResponse> GetCartItems(CancellationToken cancellationToken)
        {
            return await mediator.Send(new GetCartItemsRequest(), cancellationToken);
        }
    }
}
