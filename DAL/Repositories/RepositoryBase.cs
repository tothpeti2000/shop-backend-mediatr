using Domain.Models;
using Domain.Paging;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        protected DbSet<T> Entities { get; set; }

        public RepositoryBase(DbSet<T> entities)
        {
            Entities = entities;
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await Entities.ToListAsync(cancellationToken);
        }

        public async Task<PagedList<T>> GetAsync(Expression<Func<T, bool>> filter, PagingOptions pagingOptions, CancellationToken cancellationToken)
        {
            var matches = Entities
                .Where(filter);

            var totalCount = await matches.CountAsync(cancellationToken);
            var totalPages = (int)Math.Ceiling((double)totalCount / pagingOptions.Count);

            var entities = await matches
                .Skip((pagingOptions.Page - 1) * pagingOptions.Count)
                .Take(pagingOptions.Count)
                .ToListAsync(cancellationToken);

            return new PagedList<T>
            {
                Items = entities,
                CurrentPage = pagingOptions.Page,
                TotalPages = totalPages,
                TotalItems = totalCount
            };
        }

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await Entities.FirstOrDefaultAsync(item => item.Id == id, cancellationToken);
        }
    }
}
