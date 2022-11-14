using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISharedCartItemRepository: IRepositoryBase<SharedCartItem>
    {
        public Task<SharedCartItem> GetItemByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
