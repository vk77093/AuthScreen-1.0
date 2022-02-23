
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthScreen.Models.IdentityModel
{
    public class UserRegisterVM : IdentityUser
    {
        public string? UserId { get; set;}
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? AllowMultipleLogin { get; set; }
        public bool? BlockedOrUnBlocked { get; set; }
        public string? IpAddress { get; set; }
        public string? CompName { get; set; }
        public int? NoOfDeviceAllowed { get; set; }
        public int? NoOfConcurrentLogin { get; set; }
        public string? LoginType { get; set; }
        public string? ReportViewType { get; set; }
        public string? MainMenuType { get; set; }
        public string? TrnasctionPassoword { get; set; }
        public string? LoginId { get; set; }

    }
}
