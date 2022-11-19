using Application.Features.Profile;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProfilesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPut("edit")]
        public async Task EditProfile(EditProfileCommand command, CancellationToken cancellationToken)
        {
            await mediator.Send(command, cancellationToken);
        }
    }
}
