using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICategoryRepository: IRepositoryBase<Category>
    {
        public Task<List<Category>> GetTopCategoriesAsync(CancellationToken cancellationToken);
        public Task<HashSet<Guid>> GetDescendantIds(Guid id, CancellationToken cancellationToken);
    }
}
