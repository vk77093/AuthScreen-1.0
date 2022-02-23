using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthScreen.Models.IdentityModel
{
    public class UserEditVM
    {
        public string? Id { get; set; }
        public string? RoleName { get; set; }
        public List<string>? Users { get; set; }
    }
}
