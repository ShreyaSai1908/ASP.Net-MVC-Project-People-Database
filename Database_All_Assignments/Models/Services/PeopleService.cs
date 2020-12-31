using Database_All_Assignments.Models.Repositorys;
using Database_All_Assignments.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_All_Assignments.Models.Services
{
    public class PeopleService : IPeopleServices
    {
        private readonly IPeopleRepo pr;
        private readonly IPersonLanguageService _personLangservice;
        public PeopleService(IPeopleRepo peopleRepo, IPersonLanguageService personLangservice)
        {
            pr = peopleRepo;
            _personLangservice = personLangservice;
        }

        public Person Add(CreatePersonViewModel modelData)
        {
            Person personAdded = pr.Create(modelData.FirstName, modelData.LastName, modelData.PhoneNumber, modelData.Address);
            foreach (int languageID in modelData.ListLanguageID)
            {
                _personLangservice.Add(personAdded.PersonID, languageID);
            }
            return personAdded;
        }

        public PeopleViewModel All()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            //InMemoryPeopleRepo pr = new InMemoryPeopleRepo();
            peopleViewModel.AllPeople = pr.Read();
            return peopleViewModel;
        }
        public PeopleViewModel FindBy(PeopleViewModel pvm)
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            // InMemoryPeopleRepo pr = new InMemoryPeopleRepo();

            List<Person> searchedPeople = new List<Person>();
            peopleViewModel.AllPeople = pr.Read();

            foreach (Person person in peopleViewModel.AllPeople)
            {
                if ((person.FirstName).Contains(pvm.Search, StringComparison.OrdinalIgnoreCase) ||
                     (person.LastName).Contains(pvm.Search, StringComparison.OrdinalIgnoreCase) ||
                      (person.Address).Contains(pvm.Search, StringComparison.OrdinalIgnoreCase))
                {
                    searchedPeople.Add(person);
                }
            }

            peopleViewModel.AllPeople = searchedPeople;

            return peopleViewModel;
        }
        public Person FindBy(int findID)
        {
            //InMemoryPeopleRepo pr = new InMemoryPeopleRepo();

            List<Person> allPeople = new List<Person>();
            allPeople = pr.Read();

            Person searchedPerson = new Person();

            foreach (Person person in allPeople)
            {
                if (person.PersonID == findID)
                {
                    searchedPerson = person;
                }
            }

            return searchedPerson;
        }
        public Person Edit(int id, Person editPerson)
        {
            Person person = FindBy(id);

            person.FirstName = editPerson.FirstName;
            person.LastName = editPerson.LastName;
            person.PhoneNumber = editPerson.PhoneNumber;
            person.Address = editPerson.Address;
            pr.Update(person);

            List <PersonLanguage> matchingPersonLangList = _personLangservice.FindBy(id);

            foreach (PersonLanguage personLang in matchingPersonLangList)
            {
                _personLangservice.Remove(personLang);
            }
            foreach (int languageID in editPerson.ListLanguageID)
            {
                _personLangservice.Add(id, languageID);
            }
            return person;
        }
        public bool Remove(int findID)
        {
            bool result = false;
            //InMemoryPeopleRepo pr = new InMemoryPeopleRepo();

            List<PersonLanguage> matchingPersonLangList = _personLangservice.FindBy(findID);

            foreach (PersonLanguage personLang in matchingPersonLangList)
            {
                _personLangservice.Remove(personLang);
            }

            Person removePerson = pr.Read(findID);
            result = pr.Delete(removePerson);
            return result;
        }
    }
}
