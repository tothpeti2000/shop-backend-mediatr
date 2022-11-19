using Application.Hubs;
using Domain.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SharedCartHub : Hub<ISharedCartHub>
    {
        private readonly ISharedCartRepository sharedCartRepository;

        public SharedCartHub(ISharedCartRepository sharedCartRepository)
        {
            this.sharedCartRepository = sharedCartRepository;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = Context.User.Claims
                .ElementAt(0).Value;

            var sharedCartId = Context.GetHttpContext().Request.Query["shared_cart_id"].ElementAt(0);

            var carts = await sharedCartRepository.GetCartsOfUserAsync(Guid.Parse(userId), default);
            var cartIds = carts.Select(c => c.Id).ToList();

            if (sharedCartId != null && !cartIds.Contains(Guid.Parse(sharedCartId)))
            {
                await Clients.Caller.NotAllowed();
            } else
            {
                foreach (var cartId in cartIds)
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, cartId.ToString());
                }

                await base.OnConnectedAsync();
            }
        }
    }
}
