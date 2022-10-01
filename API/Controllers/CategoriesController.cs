using Application.Features.Category;
using Application.Features.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<GetAllCategoriesResponse> GetAllCategories(CancellationToken cancellationToken)
        {
            return await mediator.Send(new GetAllCategoriesRequest(), cancellationToken);
        }

        [HttpGet("top")]
        public async Task<GetTopCategoriesResponse> GetTopCategories(CancellationToken cancellationToken)
        {
            return await mediator.Send(new GetTopCategoriesRequest(), cancellationToken);
        }
    }
}
