using Application.Features.Auth;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("register")]
        public async Task RegisterUser([FromBody] RegisterUserCommand dto)
        {
            await mediator.Send(dto);
        }

        [HttpPost("login")]
        public async Task<LoginUserResponse> LoginUser([FromBody] LoginUserRequest dto)
        {
            return await mediator.Send(dto);
        }
    }
}
