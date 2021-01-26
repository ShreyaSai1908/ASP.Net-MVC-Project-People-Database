using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.ViewModels
{
    public class IdentityLoginViewModel
    {
        [Required]
        [StringLength(18, MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Password must be 6 long contain atleast 1 uppercase letter, a lowercase letter, a digit & a symbol.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
