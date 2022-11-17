using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [DisplayName("shared cart item")]
    public class SharedCartItem: EntityBase
    {
        public Guid SharedCartId { get; set; }
        public SharedCart SharedCart { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
