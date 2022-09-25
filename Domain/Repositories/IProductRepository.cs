using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetByQueryAsync(CancellationToken cancellationToken);
        public Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
