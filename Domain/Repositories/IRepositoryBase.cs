using Domain.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IRepositoryBase<T>
    {
        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        public Task<PagedList<T>> GetAsync(Expression<Func<T, bool>> filter, PagingOptions pagingOptions, CancellationToken cancellationToken);
        public Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken); 
    }
}
