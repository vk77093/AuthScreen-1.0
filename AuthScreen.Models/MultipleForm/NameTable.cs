using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthScreen.Models.MultipleForm
{
    public class NameTable
    {
        [Key]
        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? Pincode { get; set; }

    }
}
