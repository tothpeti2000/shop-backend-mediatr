using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CartItemRepository: RepositoryBase<CartItem>, ICartItemRepository
    {
        public CartItemRepository(ShopDbContext db) : base(db.CartItems)
        { }

        public async Task UpdateCartItemAmountAsync(Guid id, int amount, CancellationToken cancellationToken)
        {
            var cartItem = await GetByIdAsync(id, cancellationToken);
            cartItem.Amount = amount;
        }
    }
}
