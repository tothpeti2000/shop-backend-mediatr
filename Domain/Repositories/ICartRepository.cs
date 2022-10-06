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
        public Task CreateCartForUserAsync(Guid userId, CancellationToken cancellationToken);
        public Task<Cart> GetCartOfUserAsync(Guid userId, CancellationToken cancellationToken);
        public Task<List<CartItem>> GetCartItemsAsync(Guid cartId, CancellationToken cancellationToken);
    }
}
