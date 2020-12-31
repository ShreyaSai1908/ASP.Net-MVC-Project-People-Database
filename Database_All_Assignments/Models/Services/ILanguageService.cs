using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public interface ILanguageService
    {
        public Language Add(CreateLanguageViewModel createLanguageViewModel);
        public List<Language> All();
        public Language FindBy(int id);
        public List<Person> FindAllPerson(int id);
        public List<Language> FindAllLanguage(int personID);
        public Language Edit(int id, CreateLanguageViewModel edit);
        public bool Remove(int id);        
    }
}
