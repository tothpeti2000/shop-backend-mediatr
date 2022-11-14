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
    public class SharedCartRepository: RepositoryBase<SharedCart>, ISharedCartRepository
    {
        public SharedCartRepository(ShopDbContext db) : base(db.SharedCarts)
        { }

        public async Task<List<SharedCart>> GetCartsOfUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            return await GetAsync(c => c.Users.Any(u => u.Id == userId) && !c.Completed, null, cancellationToken, c => c.Users);
        }

        public async Task<List<string>> GetAllPasscodesAsync(CancellationToken cancellationToken)
        {
            var sharedCarts = await GetAllAsync(cancellationToken);

            var passcodes = sharedCarts
                .Select(c => c.Passcode)
                .ToList();

            return passcodes;
        }

        public async Task<SharedCart> GetByPasscodeAsync(string passcode, CancellationToken cancellationToken)
        {
            return await GetByConditionAsync(c => c.Passcode == passcode, cancellationToken, c => c.Users);
        }

        public async Task<SharedCart> GetCartByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await GetByIdAsync(id, cancellationToken, cart => cart.CartItems);
        }

        public async Task<List<SharedCartItem>> GetCartItemsAsync(Guid id, CancellationToken cancellationToken)
        {
            var cart = await Entities
                .Include(cart => cart.CartItems)
                .ThenInclude(cartItem => cartItem.Product)
                .FirstOrDefaultAsync(cartItem => cartItem.Id == id, cancellationToken);

            if (cart == null)
            {
                throw new EntityNotFoundException(typeof(SharedCart));
            }

            return cart.CartItems;
        }

        public async Task<string> GetNameByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var cart = await GetByIdAsync(id, cancellationToken);
            return cart.Name;
        }
    }
}
