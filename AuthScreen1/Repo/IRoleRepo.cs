using AuthScreen.Models.IdentityModel;
using Microsoft.AspNetCore.Identity;

namespace AuthScreen1.Repo
{
    public interface IRoleRepo
    {
        void AddRole(IdentityRole role);
        void DelteRole(string id);
        Task<IdentityRole?> findRoleById(string id);
        public IEnumerable<IdentityRole> GetAllRoles();
        void UpdateRole(IdentityRole roleView);
       public Task<IEnumerable<Users_in_Role_ViewModel>>? GetUserInRoles2(string roleid);
    }
}