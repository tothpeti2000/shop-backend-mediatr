﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SharedCartItem: EntityBase
    {
        public Guid CartId { get; set; }
        public SharedCart Cart { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
