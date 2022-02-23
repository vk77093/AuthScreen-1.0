using AuthScreen.Models.IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace AuthScreen1.Repo
{
    public interface IUserRepo
    {
        public Task<IEnumerable<UserRegisterVM>> GetAllUsers();
        public void AddUserToRole(IdentityUserRole<string> userRoleVM);
    }
}