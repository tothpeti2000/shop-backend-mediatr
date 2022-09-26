using Application.Features.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<GetProductsResponse> GetProducts([FromQuery] GetProductsRequest request)
        {
            return await mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<GetProductByIdResponse> GetProductById(Guid id)
        {
            return await mediator.Send(new GetProductByIdRequest(id));
        }

        [HttpGet("price-range")]
        public async Task<GetPriceRangeResponse> GetPriceRange()
        {
            return await mediator.Send(new GetPriceRangeRequest());
        }
    }
}
