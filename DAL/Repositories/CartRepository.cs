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
            var cart = await GetByConditionAsync(cart => cart.UserId == userId && !cart.Paid, cancellationToken);

            return cart.Id;
        }

        public async Task AddItemToCartAsync(Guid productId, int amount, Guid cartId, CancellationToken cancellationToken)
        {
            var cart = new Cart();
            cart = await GetByIdAsync(cartId, cancellationToken, cart => cart.CartItems);

            var cartItem = new CartItem
            {
                ProductId = productId,
                Amount = amount,
            };

            cart.CartItems
                .Add(cartItem);
        }

        public async Task CreateCartForUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            var cart = new Cart
            {
                UserId = userId
            };

            await Entities.AddAsync(cart, cancellationToken);
        }

        public async Task UpdateCartItemsAsync(Guid cartId, List<CartItem> cartItems, CancellationToken cancellationToken)
        {
            var cart = new Cart();
            cart = await GetByIdAsync(cartId, cancellationToken, cart => cart.CartItems);

            cart.CartItems = cartItems;
        }
    }
}
