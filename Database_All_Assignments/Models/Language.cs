using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models
{
    public class Language
    {
        [Key]
        public int LanguageID { get; set; }
        [Required]
        public string LanguageName { get; set; }

        [NotMapped]
        public virtual List<Person> People { get; set; }

    }
}
