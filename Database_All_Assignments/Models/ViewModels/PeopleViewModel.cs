using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> AllPeople { get; set; }

        public string Search { get; set; }

        public CreatePersonViewModel AddPerson { get; set; }

        public string ModelErr { get; set; }
    }
}
