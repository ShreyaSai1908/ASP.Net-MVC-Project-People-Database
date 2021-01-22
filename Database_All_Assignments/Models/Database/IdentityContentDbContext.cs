using Database_All_Assignments.Models.Database.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Database
{
    public class IdentityContentDbContext : IdentityDbContext<ContentUser>
    {
      public IdentityContentDbContext  (DbContextOptions<IdentityContentDbContext> options) : base(options){}

        //DbSet
        public DbSet<Person> GetPeopleList { get; set; }
        public DbSet<City> GetCitiesList { get; set; }

        public DbSet<Country> GetCountriesList { get; set; }
        public DbSet<Language> GetLanguageList { get; set; }

        public DbSet<PersonLanguage> PersonLanguage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//tells EF how to work with the many-to-many
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonLanguage>()
                .HasKey(pL => new { pL.PersonLangID });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pL => pL.Person)
                .WithMany(p => p.PersonLanguages)
                .HasForeignKey(pL => pL.PersonID);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne(pL => pL.Language)
                .WithMany(l => l.PL)
                .HasForeignKey(pL => pL.LanguageID);
        }
    }
}

