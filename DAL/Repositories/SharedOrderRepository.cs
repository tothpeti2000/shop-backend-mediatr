using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SharedOrderRepository : RepositoryBase<SharedOrder>, ISharedOrderRepository
    {
        public SharedOrderRepository(ShopDbContext db): base(db.SharedOrders)
        { }
    }
}
