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
            return await GetAsync(c => c.Users.Any(u => u.Id == userId) && !c.Paid, null, cancellationToken, c => c.Users);
        }
    }
}
