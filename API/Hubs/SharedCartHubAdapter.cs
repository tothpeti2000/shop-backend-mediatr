using Application.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
    public class SharedCartHubAdapter: ISharedCartHub
    {
        private readonly IHubContext<SharedCartHub, ISharedCartHub> hubContext;

        public SharedCartHubAdapter(IHubContext<SharedCartHub, ISharedCartHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public async Task UserJoinedCart(string message, Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .UserJoinedCart(message, cartId);
        }

        public async Task ItemAdded(string message, Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .ItemAdded(message, cartId);
        }

        public async Task ItemDeleted(string message, Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .ItemDeleted(message, cartId);
        }
    }
}
