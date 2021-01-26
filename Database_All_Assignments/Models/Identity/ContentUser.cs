using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Identity
{
    public class ContentUser : IdentityUser
    {
        
        [Column(TypeName = "NVARCHAR (100)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "NVARCHAR (100)")]
        public string LastName { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime BirthDate { get; set; }
    }
}
