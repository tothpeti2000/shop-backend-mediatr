using DAL.Exceptions;
using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CartRepository: RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ShopDbContext db) : base(db.Carts)
        { }

        public async Task CreateCartForUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            var cart = new Cart
            {
                UserId = userId
            };

            await Entities.AddAsync(cart, cancellationToken);
        }

        public async Task<Cart> GetCartOfUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            return await GetByConditionAsync(cart => cart.UserId == userId && !cart.Completed, cancellationToken, cart => cart.CartItems);
        }

        public async Task<List<CartItem>> GetCartItemsAsync(Guid cartId, CancellationToken cancellationToken)
        {
            var cart = await Entities
                .Include(cart => cart.CartItems)
                .ThenInclude(cartItem => cartItem.Product)
                .FirstOrDefaultAsync(cart => cart.Id == cartId, cancellationToken);

            if (cart == null)
            {
                throw new EntityNotFoundException();
            }

            return cart.CartItems;
        }
    }
}
