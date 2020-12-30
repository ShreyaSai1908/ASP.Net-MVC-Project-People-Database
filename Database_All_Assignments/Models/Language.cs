using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models
{
    public class Language
    {
        //[Required]
        //public List<Person> PeopleList = new List<Person>();
        [Key]
        public int LanguageID { get; set; }
        [Required]
        public string LanguageName { get; set; }

    }
}
