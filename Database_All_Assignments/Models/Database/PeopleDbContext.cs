using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Database
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        {

        }
        public DbSet<Person> GetPeopleList { get; set; }
        public DbSet<City> GetCitiesList { get; set; }

        public DbSet<Country> GetCountriesList { get; set; }
        public DbSet<Language> GetLanguageList { get; set; }

        public DbSet<PersonLanguage> PersonLanguage { get; set; }
    }
}
