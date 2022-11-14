﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Hubs
{
    public interface ISharedCartHub
    {
        Task UserJoinedCart(string message, Guid cartId);
        Task ItemAdded(string message, Guid cartId);
        Task ItemDeleted(string message, Guid cartId);
        Task ItemAmountUpdated(string message, Guid cartId);
    }
}
