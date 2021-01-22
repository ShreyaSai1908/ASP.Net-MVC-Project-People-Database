using Database_All_Assignments.Models.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Database
{
    public class DatabasePersonLangRepo : IPersonLangRepo
    {
        private readonly IdentityContentDbContext _peopleDbContext;

        public DatabasePersonLangRepo(IdentityContentDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public PersonLanguage Create(PersonLanguage personLanguage)
        {
            PersonLanguage addPersonLanguage = personLanguage;
            _peopleDbContext.Add(addPersonLanguage);
            _peopleDbContext.SaveChanges();
            return addPersonLanguage;
        }

        public bool Delete(PersonLanguage personLanguage)
        {
            bool delete = true;
            if (delete == true)
            {
                _peopleDbContext.PersonLanguage.Remove(personLanguage);
                _peopleDbContext.SaveChanges();
            }
            return delete;
        }

        public List<PersonLanguage> Read()
        {
            throw new NotImplementedException();
        }

        public List<PersonLanguage> ReadAll(int languageID)
        {
            return _peopleDbContext.PersonLanguage.Where(l => l.LanguageID == languageID).ToList();
        }

        public List<PersonLanguage> Read(int personID)
        {
            return _peopleDbContext.PersonLanguage.Where(p => p.PersonID == personID).ToList();
        }

        public List<Language> ReadAllLanguage(int personID)
        {
            List<Language> allMatchingLanguage = new List<Language>();
            List<PersonLanguage> allPersonLangList = _peopleDbContext.PersonLanguage.Where(l => l.PersonID == personID).ToList();

            foreach (PersonLanguage personLang in allPersonLangList)
            {
                int languageID = personLang.LanguageID;
                Language language = _peopleDbContext.GetLanguageList.Where(p => p.LanguageID == languageID).Single();
                allMatchingLanguage.Add(language);
            }

            return allMatchingLanguage;
        }

        public List<Person> ReadAllPerson(int languageID)
        {
            List<Person> allMatchingPerson = new List<Person>();
            
            List<PersonLanguage> allPersonLangList= _peopleDbContext.PersonLanguage.Where(l => l.LanguageID == languageID).ToList();
            foreach (PersonLanguage personLang in allPersonLangList)
            {
                int personID = personLang.PersonID;
                Person person = _peopleDbContext.GetPeopleList.Where(p => p.PersonID == personID).Single();
                allMatchingPerson.Add(person);
            }
            
            return allMatchingPerson;
        }

        public PersonLanguage Update(PersonLanguage personLanguage)
        {
            _peopleDbContext.Update(personLanguage);
            _peopleDbContext.SaveChanges();
            return personLanguage;
        }
    }
}
