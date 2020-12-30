using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public class InMemoryLanguageRepo : ILanguageRepo
    {
        private static List<Language> newLanguage = new List<Language>();
        private static int idCounter = 0;

        public Language Create(string LanguageName)
        {
            Language language = new Language();
            idCounter++;
            language.LanguageID = idCounter;
            language.LanguageName = LanguageName;
            //language.PeopleList = LanguageOfPerson;
            return language;
        }

        public bool Delete(Language language)
        {
            throw new NotImplementedException();
        }

        public List<Language> Read()
        {
            throw new NotImplementedException();
        }

        public Language Read(int languageID)
        {
            throw new NotImplementedException();
        }

        public List<Language> ReadAllLanguage(int id)
        {
            throw new NotImplementedException();
        }

        public Language Update(Language language)
        {
            throw new NotImplementedException();
        }
    }
}
