using DAL.Exceptions;
using DAL.Helpers;
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
        protected SortHelper<T> sortHelper = new();

        public RepositoryBase(DbSet<T> entities)
        {
            Entities = entities;
        }

        public async Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            await Entities.AddAsync(entity, cancellationToken);
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> filter, string? orderByString, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Entities.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var filtered = query
                .Where(filter);

            var sorted = sortHelper.ApplySort(filtered, orderByString);

            return await sorted
                .ToListAsync(cancellationToken);
        }

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes)
        {
            return await GetAsync(_ => true, null, cancellationToken, includes);
        }

        public async Task<PagedList<T>> GetPagedAsync(Expression<Func<T, bool>> filter, string? orderByString, int page, int count, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Entities.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var filtered = query
                .Where(filter);

            var sorted = sortHelper.ApplySort(filtered, orderByString);

            var totalCount = await sorted.CountAsync(cancellationToken);
            var totalPages = (int)Math.Ceiling((double)totalCount / count);

            var entities = await sorted
                .Skip((page - 1) * count)
                .Take(count)
                .ToListAsync(cancellationToken);

            return new PagedList<T>
            {
                Items = entities,
                CurrentPage = page,
                TotalPages = totalPages,
                TotalItems = totalCount
            };
        }

        public async Task<T> GetByConditionAsync(Expression<Func<T, bool>> condition, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = Entities.AsQueryable();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            var entity = await query.FirstOrDefaultAsync(condition, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(T));
            }

            return entity;
        }

        public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken, params Expression<Func<T, object>>[] includes)
        {
            return await GetByConditionAsync(item => item.Id == id, cancellationToken, includes);
        }

        public async Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await GetByIdAsync(id, cancellationToken);
            Entities.Remove(entity);
        }
    }
}
