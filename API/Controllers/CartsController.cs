using Application.Features.Cart;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly IMediator mediator;

        public CartsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPut("add-item")]
        public async Task AddItemToCart(AddItemToCartCommand command, CancellationToken cancellationToken)
        {   
            await mediator.Send(command, cancellationToken);
        }

        [HttpGet("items")]
        public async Task<GetCartItemsResponse> GetCartItems(CancellationToken cancellationToken)
        {
            return await mediator.Send(new GetCartItemsRequest(), cancellationToken);
        }

        [HttpPut("update-item")]
        public async Task UpdateCartItemAmount(UpdateCartItemAmountCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
        }

        [HttpPut("delete-item")]
        public async Task DeleteCartItem(DeleteCartItemCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
        }

        [HttpPut("clear")]
        public async Task ClearCart(CancellationToken cancellationToken)
        {
            await mediator.Send(new ClearCartCommand(), cancellationToken);
        }
    }
}
