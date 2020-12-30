using Database_All_Assignments.Models.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Database
{
    public class DatabasePersonLangRepo : IPersonLangRepo
    {
        private readonly PeopleDbContext _peopleDbContext;

        public DatabasePersonLangRepo(PeopleDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public PersonLanguage Create(PersonLanguage personLanguage)
        {
            PersonLanguage addPersonLanguage = personLanguage;
            _peopleDbContext.Add(addPersonLanguage);
            _peopleDbContext.SaveChanges();
            return addPersonLanguage;
        }

        public bool Delete(PersonLanguage personLanguage)
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> Read()
        {
            throw new NotImplementedException();
        }

        public PersonLanguage Read(int personLanguageID)
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> ReadAllLanguage(int id)
        {
            throw new NotImplementedException();
        }

        public PersonLanguage Update(PersonLanguage personLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
