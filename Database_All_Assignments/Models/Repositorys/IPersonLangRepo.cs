using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Repositorys
{
    public interface IPersonLangRepo
    {
        public PersonLanguage Create(PersonLanguage personLanguage);
        public List<PersonLanguage> Read();
        public PersonLanguage Read(int personLanguageID);
        public List<PersonLanguage> ReadAllLanguage(int id);
        public PersonLanguage Update(PersonLanguage personLanguage);
        public bool Delete(PersonLanguage personLanguage);
    }
}
