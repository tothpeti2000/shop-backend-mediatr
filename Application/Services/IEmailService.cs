using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IEmailService
    {
        public Task SendOrderConfirmationEmailAsync(Order order, string name, string email);
        public Task SendSharedOrderConfirmationEmailAsync(SharedOrder order, string name, string email, bool isOrderPlacingUser);
        public Task SendPasswordResetEmailAsync(string resetToken, Guid userId, string name, string email);
    }
}
