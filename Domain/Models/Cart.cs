﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cart: EntityBase
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public List<CartItem> CartItems { get; set; }
        public bool Paid { get; set; }
    }
}
