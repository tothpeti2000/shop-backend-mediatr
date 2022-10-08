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
        public Task AddAsync(T entity, CancellationToken cancellationToken);
        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken);
        public Task<List<T>> GetAsync(Expression<Func<T, bool>> filter, string? orderByString, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes);
        public Task<PagedList<T>> GetPagedAsync(Expression<Func<T, bool>> filter, string? orderByString, int page, int count, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes);
        public Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes);
        public Task<T> GetByConditionAsync(Expression<Func<T, bool>> condition, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes);
        public Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
