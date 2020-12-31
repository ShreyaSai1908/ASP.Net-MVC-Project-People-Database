using Database_All_Assignments.Models.Repositorys;
using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public class PersonLanguageService : IPersonLanguageService
    {
        private readonly IPersonLangRepo _personLangRepo;
        public PersonLanguageService(IPersonLangRepo personLangRepo)
        {
            _personLangRepo = personLangRepo;             
        }

        public PersonLanguage Add(int personID, int languageID)
        {
            PersonLanguage personLang = new PersonLanguage() { PersonID = personID, LanguageID = languageID };
            _personLangRepo.Create(personLang);
            return personLang;
        }

        public List<PersonLanguage> All()
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> All(int languageID)
        {
            return _personLangRepo.ReadAll(languageID);
        }

        public PersonLanguage Edit(int id, CreateLanguageViewModel edit)
        {
            return null;
        }        

        public PersonLanguage FindBy(int personLangID)
        {
            return _personLangRepo.Read(personLangID);
        }

        public List<Person> FindAllPerson(int languageID)
        {
            return _personLangRepo.ReadAllPerson(languageID); 
        }

        public bool Remove(PersonLanguage personLang)
        {
            return _personLangRepo.Delete(personLang);
        }
    }
}
