using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        public List<Country> CountryList { get; set; }
        public List<int> ListCityID { get; set; }

        [Required]
        public List<City> CityList = new List<City>();

        [Key]
        public int CountryId { get; set; }

        [Required]
        public string CountryName { get; set; }
    }
}
