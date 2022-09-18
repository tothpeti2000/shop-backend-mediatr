using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ShopDbContext db;

        public UnitOfWork(ShopDbContext db)
        {
            this.db = db;
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException exc)
            {
                var entity = exc.Entries[0];
                var message = $"Invalid {entity?.Entity.GetType().Name} ID: {entity?.Property("Id").OriginalValue}";

                throw new InvalidOperationException(message, exc);
            }
        }
    }
}
