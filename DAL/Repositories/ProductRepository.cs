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
    public class ProductRepository: IProductRepository
    {
        private readonly ShopDbContext db;

        public ProductRepository(ShopDbContext db)
        { 
            this.db = db;
        }

        public async Task<List<Product>> GetByQueryAsync(CancellationToken cancellationToken)
        {
            return await db.Products
                .ToListAsync(cancellationToken);
        }

        public async Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await db.Products
                .FirstOrDefaultAsync(product => product.Id == id, cancellationToken);
        }

        public async Task<(double, double)> GetPriceRangeAsync(CancellationToken cancellationToken)
        {
            var prices = db.Products
                .Select(product => product.Price);

            var minPrice = await prices.MinAsync(cancellationToken);
            var maxPrice = await prices.MaxAsync(cancellationToken);

            return (minPrice, maxPrice);
        }
    }
}
