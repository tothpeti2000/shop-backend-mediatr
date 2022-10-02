using Application.Services;
using System.Security.Claims;

namespace API.Services
{
    public class UserService : IUserService
    {
        public ClaimsPrincipal User { get; }

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            User = httpContextAccessor.HttpContext.User;
        }

        public Guid GetUserIdFromContext()
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdString == null)
            {
                throw new InvalidOperationException();
            }

            return Guid.Parse(userIdString);
        }
    }
}
