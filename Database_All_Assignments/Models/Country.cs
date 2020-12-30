using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models
{
    public class Country
    {
        [Required]
        public List<City> CityList = new List<City>();

        [Key]
        public int CountryId { get; set; }

        [Required]
        public string CountryName { get; set; }
    }
}
