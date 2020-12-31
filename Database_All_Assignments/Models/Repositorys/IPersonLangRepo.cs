using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public interface IPersonLangRepo
    {
        public PersonLanguage Create(PersonLanguage personLanguage);
        public List<PersonLanguage> Read();
        public List<PersonLanguage> ReadAll(int languageID);
        public List<PersonLanguage> Read(int personID);
        public List<Language> ReadAllLanguage(int personID);
        public List<Person> ReadAllPerson(int languageID);
        public PersonLanguage Update(PersonLanguage personLanguage);
        public bool Delete(PersonLanguage personLanguage);
    }
}
