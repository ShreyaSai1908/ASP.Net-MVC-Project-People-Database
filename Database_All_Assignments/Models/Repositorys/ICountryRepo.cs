using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public interface ICountryRepo
    {
        public Country Create(List<City> CityInCountry, string CountryName);
        public List<Country> Read();
        public Country Read(int id);
        public List<City> ReadAllCity(int id);
        public Country Update(Country country);
        public bool Delete(Country country);
    }
}
