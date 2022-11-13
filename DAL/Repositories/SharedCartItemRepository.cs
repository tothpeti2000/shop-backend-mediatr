using Domain.Models;
using Domain.Repositories;
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
    }
}
