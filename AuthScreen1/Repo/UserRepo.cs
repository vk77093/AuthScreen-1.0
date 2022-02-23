using AuthScreen.Models.IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace AuthScreen1.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly UserManager<UserRegisterVM> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserRepo(UserManager<UserRegisterVM> userManager,RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<IEnumerable<UserRegisterVM>> GetAllUsers()
        {
            var user = userManager.Users;
            return user.ToList();
        }
        public async void AddUserToRole(IdentityUserRole<string> userRoleVM)
        {

            var user = await userManager.FindByIdAsync(userRoleVM.UserId);
            if (user != null)
            {
                var role = await roleManager.FindByIdAsync(userRoleVM.RoleId);
                await userManager.AddToRoleAsync(user, role.Name);
            }
            else
            {
                throw new Exception();
            }

        }
    }
}
