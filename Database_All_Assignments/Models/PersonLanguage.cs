using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Database_All_Assignments.Models
{
    public class PersonLanguage
    {
        [Key]
        public int PersonLangID { get; set; }
        public int PersonID { get; set; }
        public int LanguageID { get; set; }
        public virtual Person Person { get; set; }
        public virtual Language Language { get; set; }
    }
}
