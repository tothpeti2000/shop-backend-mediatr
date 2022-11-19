using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUserService
    {
        public Guid GetUserIdFromContext();
        public Task CreateUserAsync(User user, string password);
        public Task<User> GetByNameAsync(string name);
        public Task<User> GetByEmailAsync(string email);
        public Task<User> GetByIdAsync(Guid id);
        public Task<bool> CheckPasswordAsync(User user, string password);
        public Task<string> GetUserEmailAsync(Guid userId);
        public Task UpdateNameAsync(Guid userId, string name);
        public Task UpdatePasswordAsync(Guid userId, string currentPassword, string newPassword);
        public Task<string> GeneratePasswordResetTokenAsync(User user);
        public Task ResetPasswordAsync(User user, string resetToken, string newPassword);
    }
}
