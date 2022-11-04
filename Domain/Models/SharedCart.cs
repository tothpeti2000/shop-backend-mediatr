using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SharedCart: EntityBase
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Passcode { get; set; }
        public List<User> Users { get; set; }
        public List<SharedCartItem> CartItems { get; set; }
        public bool Paid { get; set; }
    }
}
