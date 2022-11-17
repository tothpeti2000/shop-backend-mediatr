using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SharedOrder: EntityBase
    {
        public Guid SharedCartId { get; set; }
        public SharedCart SharedCart { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public bool Paid { get; set; }
    }
}
