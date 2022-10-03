using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class EntityNotFoundException: Exception
    {
        public EntityNotFoundException()
            : base($"The requested entity wasn't found") { }
    }
}
