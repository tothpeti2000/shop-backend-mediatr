using DAL.Exceptions;
using Domain.Models;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CartRepository: RepositoryBase<Cart>, ICartRepository
    {
        public CartRepository(ShopDbContext db) : base(db.Carts)
        { }

        public async Task<Guid> GetCartIdOfUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            var cart = await Entities
                .FirstOrDefaultAsync(cart => cart.UserId == userId);

            if (cart == null)
            {
                throw new EntityNotFoundException(userId);
            }

            return cart.Id;
        }

        public async Task AddItemToCartAsync(Guid productId, int amount, Guid cartId, CancellationToken cancellationToken)
        {
            var cart = await GetByIdAsync(cartId, cancellationToken);

            var cartItem = new CartItem
            {
                ProductId = productId,
                Amount = amount,
            };

            cart.CartItems
                .Add(cartItem);
        }
    }
}
