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
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        private readonly IProductRepository productRepository;

        public CategoryRepository(ShopDbContext db, IProductRepository productRepository): base(db.Categories)
        { 
            this.productRepository = productRepository;
        }

        public async Task<List<Category>> GetTopCategoriesAsync(CancellationToken cancellationToken)
        {
            var topCategoryIds = await productRepository.GetTopProductCategoryIdsAsync(cancellationToken);

            return await Entities
                .Where(c => topCategoryIds.Contains(c.Id))
                .ToListAsync(cancellationToken);
        }

        public async Task<HashSet<Guid>> GetDescendantIds(Guid id, CancellationToken cancellationToken)
        {
            var categories = await GetAllAsync(cancellationToken, category => category.ParentCategory);

            var descendantIds = new HashSet<Guid>();

            foreach (var category in categories)
            {
                if (IsAncestorOf(id, category))
                {
                    descendantIds.Add(category.Id);
                }
            }

            return descendantIds;
        }

        private static bool IsAncestorOf(Guid ancestorId, Category? descendant)
        {
            if (descendant == null)
            {
                return false;
            }

            return descendant.ParentCategoryId == ancestorId || IsAncestorOf(ancestorId, descendant.ParentCategory);
        }
    }
}
