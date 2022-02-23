using AuthScreen.Models.IdentityModel;
using AuthScreen1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuthScreen1.Repo
{
    public class RoleRepo : IRoleRepo
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext dbContext;

        public RoleRepo(RoleManager<IdentityRole> roleManager,ApplicationDbContext dbContext)
        {
            this.roleManager = roleManager;
            this.dbContext = dbContext;
        }
        public IEnumerable<IdentityRole> GetAllRoles()
        {
            var roles = roleManager.Roles.ToList();
            return roles;

        }
        public async void AddRole(IdentityRole role)
        {
            role = new IdentityRole()
            {
                Name = role.Name,
                NormalizedName = role.Name.ToUpperInvariant(),
            };
             await roleManager.CreateAsync(role);

        }
        public async Task<IdentityRole?> findRoleById(string id)
        {
            var roleid = await roleManager.FindByIdAsync(id);
            if (roleid != null) return roleid;
            return null;
        }
        public async void UpdateRole(IdentityRole roleView)
        {
            var rolid = findRoleById(roleView.Id);
            if (rolid == null) return;

            await roleManager.UpdateAsync(roleView);

        }
        public async void DelteRole(string id)
        {
            var rolid = await roleManager.FindByIdAsync(id);
            if (rolid == null) return;
            await roleManager.DeleteAsync(rolid);
        }

        public async Task<IEnumerable<Users_in_Role_ViewModel>>? GetUserInRoles2(string roleid)
        {
            //return null;
            var reg = (from userRoles in dbContext.UserRoles
                       join users in dbContext.Users on userRoles.UserId equals users.Id
                       join roles in dbContext.Roles on userRoles.RoleId equals roles.Id
                       where (userRoles.RoleId==roleid)
                       select new Users_in_Role_ViewModel
                       {
                           Role = roles.Name,
                           UserId = users.Id,
                           Username = users.UserName,
                           Email = users.Email,
                       }
                    ).ToList();
            return reg;
        }
    }
}
