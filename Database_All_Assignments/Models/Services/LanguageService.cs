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

        public LanguageService(ILanguageRepo languageRepo, IPeopleRepo peopleRepo, IPersonLanguageService personLangService, IPersonLangRepo personLangRepo)
        {
            _languageRepo = languageRepo;
            _peopleRepo = peopleRepo;
            _personLangService = personLangService;
            _personLangRepo = personLangRepo;
        }

        public Language Add(CreateLanguageViewModel createLanguageViewModel)
        {
            Language language = _languageRepo.Create(createLanguageViewModel.LanguageName);

            List<Language> langList = new List<Language>();
            langList.Add(language);

            List<Person> peopleList = new List<Person>();

            foreach (int id in createLanguageViewModel.ListPersonID)
            {
                Person person=_peopleRepo.Read(id);
                peopleList.Add(person);
            }

            _personLangService.Add(peopleList, langList);

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

        public Language FindBy(int id)
        {
            return _languageRepo.Read(id);
        }

        public bool Remove(int id)
        {
            return _languageRepo.Delete(FindBy(id));
        }
    }
}
