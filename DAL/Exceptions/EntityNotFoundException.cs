using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException(Guid id)
            : base($"Entity with ID {id} wasn't found") { }
    }
}
