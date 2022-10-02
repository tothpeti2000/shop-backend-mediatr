﻿using DAL.Helpers;
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

        public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await Entities.ToListAsync(cancellationToken);
        }

        public async Task<PagedList<T>> GetAsync(Expression<Func<T, bool>> filter, string? orderByString, int page, int count, CancellationToken cancellationToken)
        {
            var filtered = Entities
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

        public async Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await Entities.FirstOrDefaultAsync(item => item.Id == id, cancellationToken);
        }
    }
}