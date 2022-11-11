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

        public async Task<IdentityResult> CreateUserAsync(User user, string password)
        {
            return await userManager.CreateAsync(user, password);
        }

        public async Task<User> GetByNameAsync(string name)
        {
            return await userManager.FindByNameAsync(name);
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
    }
}
