using Database_All_Assignments.Models.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Database
{
    public class DatabaseLanguageRepo : ILanguageRepo
    {
        private readonly IdentityContentDbContext _peopleDbContext;

        public DatabaseLanguageRepo(IdentityContentDbContext peopleDbContext)
        {
            _peopleDbContext = peopleDbContext;
        }

        public Language Create(Language lang)
        {
            //Language addingLanguage = new Language() { LanguageName = LanguageName };
            Language addingLanguage = lang;
            _peopleDbContext.Add(addingLanguage);
            _peopleDbContext.SaveChanges();
            return addingLanguage;
        }

        public bool Delete(Language language)
        {
            bool delete = true;
            if (delete == true)
            {
                _peopleDbContext.GetLanguageList.Remove(language);
                _peopleDbContext.SaveChanges();
            }
            return delete;
        }

        public List<Language> Read()
        {
            return _peopleDbContext.GetLanguageList.ToList();     
        }

        public Language Read(int languageID)
        {
            return _peopleDbContext.GetLanguageList.Find(languageID);
        }

        public List<Language> ReadAllLanguage(int id)
        {
            return _peopleDbContext.GetLanguageList.Where(l => l.LanguageID == id).ToList();
        }

        public List<Person> ReadAllPerson(int id)
        {
            return null;
        }

        public Language Update(Language language)
        {
            _peopleDbContext.Update(language);
            _peopleDbContext.SaveChanges();
            return language;
        }
    }
}
