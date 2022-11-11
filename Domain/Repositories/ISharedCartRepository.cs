using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISharedCartRepository: IRepositoryBase<SharedCart>
    {
        public Task<List<SharedCart>> GetCartsOfUserAsync(Guid userId, CancellationToken cancellationToken);
        public Task<List<string>> GetAllPasscodesAsync(CancellationToken cancellationToken);
        public Task<SharedCart> GetByPasscodeAsync(string passcode, CancellationToken cancellationToken);
    }
}
