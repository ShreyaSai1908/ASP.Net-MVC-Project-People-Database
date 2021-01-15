using Database_All_Assignments.Models.Repositorys;
using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepo _languageRepo;
        private readonly IPeopleRepo _peopleRepo;
        private readonly IPersonLanguageService _personLangService;
        private readonly IPersonLangRepo _personLangRepo;
        private readonly IPeopleServices _peopleService;


        public LanguageService(ILanguageRepo languageRepo, IPeopleRepo peopleRepo, IPersonLanguageService personLangService, IPersonLangRepo personLangRepo, IPeopleServices peopleService)
        {
            _languageRepo = languageRepo;
            _peopleRepo = peopleRepo;
            _personLangService = personLangService;
            _personLangRepo = personLangRepo;
            _peopleService = peopleService;
        }

        public Language Add(CreateLanguageViewModel createLanguageViewModel)
        {
            Language lang = new Language(); //new language to be added

            List<PersonLanguage> allPersonLang = new List<PersonLanguage>(); //placeholder list
            foreach (int id in createLanguageViewModel.ListPersonID)
            {
                lang.LanguageName = createLanguageViewModel.LanguageName;

                PersonLanguage personLang = new PersonLanguage();

                personLang.LanguageID = lang.LanguageID; //createLanguageViewModel.LanguageID;
                personLang.Person = _peopleService.FindBy(id);
                personLang.Language = lang;
                personLang.PersonID = id;

                allPersonLang.Add(personLang);

                lang.PL = allPersonLang;
                //_personLangService.Add(id, language.LanguageID);
            }
            Language language = _languageRepo.Create(lang);

            return language;
        }

        public List<Language> All()
        {
            return _languageRepo.Read();
        }

        public Language Edit(int id, CreateLanguageViewModel edit)
        {
            Language editedLanguage = new Language() { LanguageID = id, LanguageName = edit.LanguageName };
            return _languageRepo.Update(editedLanguage);
        }

        public List<Language> FindAllLanguage(int id)
        {
            return _languageRepo.ReadAllLanguage(id);
        }

        public List<Person> FindAllPerson(int id)
        {
            return _languageRepo.ReadAllPerson(id);
        }

        public Language FindBy(int id)
        {
            return _languageRepo.Read(id);
        }

        public bool Remove(int id)
        {
            /*List <PersonLanguage> removePersonLang=_personLangService.All(id);
            foreach (PersonLanguage personLang in removePersonLang)
            {
                _personLangRepo.Delete(personLang);
            }*/
            return _languageRepo.Delete(FindBy(id));
        }
    }
}
