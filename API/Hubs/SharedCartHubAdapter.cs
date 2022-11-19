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

        public async Task NotAllowed()
        {
            throw new NotImplementedException();
        }

        public async Task UserJoinedCart(ActionDetails details)
        {
            await hubContext.Clients.Group(details.CartId.ToString())
                .UserJoinedCart(details);
        }

        public async Task ItemAdded(ActionDetails details)
        {
            await hubContext.Clients.Group(details.CartId.ToString())
                .ItemAdded(details);
        }

        public async Task ItemDeleted(ActionDetails details)
        {
            await hubContext.Clients.Group(details.CartId.ToString())
                .ItemDeleted(details);
        }

        public async Task ItemAmountUpdated(ActionDetails details)
        {
            await hubContext.Clients.Group(details.CartId.ToString())
                .ItemAmountUpdated(details);
        }

        public async Task CheckoutStarted(Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .CheckoutStarted(cartId);
        }

        public async Task CheckoutAborted(Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .CheckoutAborted(cartId);
        }

        public async Task OrderPlaced(Guid cartId)
        {
            await hubContext.Clients.Group(cartId.ToString())
                .OrderPlaced(cartId);
        }
    }
}
