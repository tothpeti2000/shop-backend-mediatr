using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hubs
{
    public interface ISharedCartHub
    {
        Task UserJoinedCart(string message, Guid cartId);
        Task ItemAdded(ActionDetails details, Guid cartId);
        Task ItemDeleted(ActionDetails details, Guid cartId);
        Task ItemAmountUpdated(ActionDetails details, Guid cartId);
    }

    public class ActionDetails
    {
        public string Message { get; set; }
        public Guid CartId { get; set; }
    }
}
