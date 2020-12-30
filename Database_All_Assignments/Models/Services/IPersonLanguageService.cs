using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public interface IPersonLanguageService
    {
        public PersonLanguage Add(List<Person> peopleList, List<Language> langList);
        public List<PersonLanguage> All();
        public PersonLanguage FindBy(int id);
        public PersonLanguage Edit(int id, CreateLanguageViewModel edit);
        public bool Remove(int id);
        public List<PersonLanguage> FindAllLanguage(int id);
    }
}
