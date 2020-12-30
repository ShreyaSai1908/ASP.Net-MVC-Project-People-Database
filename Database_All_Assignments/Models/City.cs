using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public List<Person> PersonInCity { get; set; }

        [Required]
        public string CityName { get; set; }

        [Required]
        public string States { get; set; }

        public Country Country { get; set; }

    }
}

