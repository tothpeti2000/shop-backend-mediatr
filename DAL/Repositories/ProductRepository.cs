using Domain.Models;
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
    public class ProductRepository: RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ShopDbContext db): base(db.Products)
        { }

        public async Task<(double, double)> GetPriceRangeAsync(CancellationToken cancellationToken)
        {
            var prices = Entities
                .Select(product => product.Price);

            var minPrice = await prices.MinAsync(cancellationToken);
            var maxPrice = await prices.MaxAsync(cancellationToken);

            return (minPrice, maxPrice);
        }

        public async Task<List<Guid>> GetTopProductCategoryIdsAsync(CancellationToken cancellationToken)
        {
            return await Entities
                .GroupBy(p => p.CategoryId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .Take(3)
                .ToListAsync(cancellationToken);
        }

        public async Task<bool> CheckStockAsync(Guid id, int amount, CancellationToken cancellationToken)
        {
            var product = await GetByIdAsync(id, cancellationToken);

            return product.Stock >= amount;
        }

        public async Task DecreaseStockAsync(Guid id, int amount, CancellationToken cancellationToken)
        {
            var product = await GetByIdAsync(id, cancellationToken);
            product.Stock -= amount;
        }
    }
}
