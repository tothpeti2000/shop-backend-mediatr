using Application.Services;
using DAL;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace API.Services
{
    public class UserService : IUserService
    {
        private readonly ClaimsPrincipal user;
        private readonly UserManager<User> userManager;

        public UserService(IHttpContextAccessor httpContextAccessor, UserManager<User> userManager)
        {
            user = httpContextAccessor.HttpContext.User;
            this.userManager = userManager;
        }

        public Guid GetUserIdFromContext()
        {
            var userIdString = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdString == null)
            {
                throw new InvalidOperationException();
            }

            return Guid.Parse(userIdString);
        }

        public async Task CreateUserAsync(User user, string password)
        {
            await userManager.CreateAsync(user, password);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await userManager.FindByNameAsync(name);
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await userManager.FindByIdAsync(id.ToString());
        }

        public async Task<bool> CheckPasswordAsync(User user, string password)
        {
            return await userManager.CheckPasswordAsync(user, password);
        }

        public async Task<string> GetUserEmailAsync(Guid userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            return await userManager.GetEmailAsync(user);
        }

        public async Task UpdateNameAsync(Guid userId, string name)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            user.Name = name;

            var result = await userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description}\n";
                }

                throw new InvalidOperationException(errors);
            }
        }

        public async Task UpdatePasswordAsync(Guid userId, string currentPassword, string newPassword)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            var result = await userManager.ChangePasswordAsync(user, currentPassword, newPassword);

            if (!result.Succeeded)
            {
                var errors = string.Empty;

                foreach (var error in result.Errors)
                {
                    errors += $"{error.Description}\n";
                }

                throw new InvalidOperationException(errors);
            }
        }
    }
}
