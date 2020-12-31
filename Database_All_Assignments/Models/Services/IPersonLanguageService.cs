using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public interface IPersonLanguageService
    {
        public PersonLanguage Add(int personID, int languageID);
        public List<PersonLanguage> All();
        public List<PersonLanguage> All(int languageID);
        public PersonLanguage FindBy(int id);
        public PersonLanguage Edit(int id, CreateLanguageViewModel edit);
        public List<Person> FindAllPerson(int id);
        public List<Language> FindAllLanguage(int id);
        public bool Remove(PersonLanguage personLang);
    }
}
