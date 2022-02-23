using AuthScreen.Models.IdentityModel;
using AuthScreen.Models.MultipleForm;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthScreen1.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserRegisterVM,IdentityRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NameTable>? NameTables { get; set; }
    }
}