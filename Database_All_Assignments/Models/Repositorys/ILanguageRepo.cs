using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public interface ILanguageRepo
    {
        public Language Create(string LanguageName);
        public List<Language> Read();
        public Language Read(int languageID);
        public List<Language> ReadAllLanguage(int id);
        public List<Person> ReadAllPerson(int id);
        public Language Update(Language language);
        public bool Delete(Language language);
    }
}
