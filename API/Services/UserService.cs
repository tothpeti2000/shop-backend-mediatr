using Domain.Services;
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
        private readonly ITokenGenerator tokenGenerator;

        public UserService(
            IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager,
            ITokenGenerator tokenGenerator)
        {
            user = httpContextAccessor.HttpContext.User;
            this.userManager = userManager;
            this.tokenGenerator = tokenGenerator;
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

        public string GenerateTokenForUser(Guid userId)
        {
            return tokenGenerator.GenerateToken(userId);
        }

        public async Task CreateUserAsync(User user, string password)
        {
            var result = await userManager.CreateAsync(user, password);
            CheckResult(result);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await userManager.FindByNameAsync(name);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
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
            CheckResult(result);
        }

        public async Task UpdatePasswordAsync(Guid userId, string currentPassword, string newPassword)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            var result = await userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            CheckResult(result);
        }

        public async Task<string> GeneratePasswordResetTokenAsync(User user)
        {
            return await userManager.GeneratePasswordResetTokenAsync(user);
        }

        public async Task ResetPasswordAsync(User user, string resetToken, string newPassword)
        {
            var result = await userManager.ResetPasswordAsync(user, resetToken, newPassword);
            CheckResult(result);
        }

        private static void CheckResult(IdentityResult result)
        {
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
