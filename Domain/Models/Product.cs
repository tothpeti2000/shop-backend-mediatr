using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product: EntityBase
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public double AverageRating { get; set; }
        public string? ImgUrl { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
