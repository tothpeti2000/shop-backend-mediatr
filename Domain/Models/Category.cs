using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Category: EntityBase
    {
        public string Name { get; set; }
        public string? ImgUrl { get; set; }

        public Guid? ParentCategoryId { get; set; }
        public Category? ParentCategory { get; set; }
    }
}
