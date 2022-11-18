using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hubs
{
    public interface ISharedCartHub
    {
        Task UserJoinedCart(ActionDetails details);
        Task ItemAdded(ActionDetails details);
        Task ItemDeleted(ActionDetails details);
        Task ItemAmountUpdated(ActionDetails details);
        Task CheckoutStarted(Guid cartId);
        Task CheckoutAborted(Guid cartId);
        Task OrderPlaced(Guid cartId);
    }

    public class ActionDetails
    {
        public Guid CartId { get; set; }
        public string? Message { get; set; }
    }
}
