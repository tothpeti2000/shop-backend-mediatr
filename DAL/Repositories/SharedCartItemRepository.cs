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
    public class SharedCartItemRepository : RepositoryBase<SharedCartItem>, ISharedCartItemRepository
    {
        public SharedCartItemRepository(ShopDbContext db): base(db.SharedCartItems)
        { }

        public async Task<SharedCartItem> GetItemByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var cartItem = await Entities
                .Include(cartItem => cartItem.Cart)
                .Include(cartItem => cartItem.Product)
                .FirstOrDefaultAsync(cartItem => cartItem.Id == id, cancellationToken);

            if (cartItem == null)
            {
                throw new EntityNotFoundException(typeof(SharedCartItem));
            }

            return cartItem;
        }
    }
}
