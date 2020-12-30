using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.ViewModels
{
    public class CreateLanguageViewModel
    {
        
        public List<Person> PeopleList { get; set; }
        [Key]
        public int LanguageID { get; set; }
        [Required]
        public string LanguageName { get; set; }
        public List<int> ListPersonID { get; set; }

        public List<int> ListLanguageID { get; set; }
        public List<Language> LanguageList { get; set; }


    }
}
