using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProductRepository: IRepositoryBase<Product>
    {
        public Task<(double, double)> GetPriceRangeAsync(CancellationToken cancellationToken);
        public Task<List<Guid>> GetTopProductCategoryIdsAsync(CancellationToken cancellationToken);
    }
}
