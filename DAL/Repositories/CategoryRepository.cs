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

        public async Task<List<Category>> GetTopCategories(CancellationToken cancellationToken)
        {
            var topCategoryIds = await productRepository.GetTopProductCategoryIdsAsync(cancellationToken);

            return await Entities
                .Where(c => topCategoryIds.Contains(c.Id))
                .ToListAsync(cancellationToken);
        }
    }
}
