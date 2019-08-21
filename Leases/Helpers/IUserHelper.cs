using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Leases.Data.Entities;
using Leases.Models;

namespace Leases.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginDto model);

        Task LogoutAsync();

    }
}
