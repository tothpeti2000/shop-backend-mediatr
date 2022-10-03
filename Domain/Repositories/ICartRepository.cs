using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICartRepository: IRepositoryBase<Cart>
    {
        public Task<Guid> GetCartIdOfUserAsync(Guid userId, CancellationToken cancellationToken);
        public Task AddItemToCartAsync(Guid productId, int amount, Guid cartId, CancellationToken cancellationToken);
        public Task CreateCartForUserAsync(Guid userId, CancellationToken cancellationToken);
        public Task UpdateCartItemsAsync(Guid cartId, List<CartItem> cartItems, CancellationToken cancellationToken);
    }
}
