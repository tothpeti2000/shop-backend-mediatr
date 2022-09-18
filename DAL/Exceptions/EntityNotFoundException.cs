using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(Type entityType, Guid id)
            : base($"No {entityType.Name} was found in the DB with ID {id}") { }
    }
}
