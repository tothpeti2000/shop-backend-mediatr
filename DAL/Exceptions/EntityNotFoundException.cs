using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(Type entityType)
            : base($"The requested {GetDisplayName(entityType)} wasn't found") { }

        private static string GetDisplayName(Type entityType)
        {
            return (entityType.GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault() as DisplayNameAttribute).DisplayName ?? "entity";
        }
    }
}
