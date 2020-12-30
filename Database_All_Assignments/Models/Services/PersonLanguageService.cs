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

        public PersonLanguage Add(List<Person> peopleList, List<Language> langList)
        {
            PersonLanguage personLang = new PersonLanguage() { PersonList = peopleList, LanguageList = langList };
            _personLangRepo.Create(personLang);
            return personLang;
        }

        public List<PersonLanguage> All()
        {
            throw new NotImplementedException();
        }

        public PersonLanguage Edit(int id, CreateLanguageViewModel edit)
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> FindAllLanguage(int id)
        {
            throw new NotImplementedException();
        }

        public PersonLanguage FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
