using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public class InMemoryPersonLangRepo : IPersonLangRepo
    {
        public PersonLanguage Create(PersonLanguage personLanguage)
        {
            throw new NotImplementedException();
        }

        public bool Delete(PersonLanguage personLanguage)
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> Read()
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> Read(int personID)
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> ReadAll(int languageID)
        {
            throw new NotImplementedException();
        }

        public List<Language> ReadAllLanguage(int personID)
        {
            throw new NotImplementedException();
        }

        public List<Person> ReadAllPerson(int languageID)
        {
            throw new NotImplementedException();
        }

        public PersonLanguage Update(PersonLanguage personLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
