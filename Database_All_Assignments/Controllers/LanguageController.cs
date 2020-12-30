using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_All_Assignments.Models;
using Database_All_Assignments.Models.Repositorys;
using Database_All_Assignments.Models.Services;
using Database_All_Assignments.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Database_All_Assignments.Controllers
{
    public class LanguageController : Controller

    {
        private readonly IPeopleServices _peopleService;
        private readonly ILanguageService _languageService;

        public LanguageController(IPeopleServices peopleService, ILanguageService languageService)
        {
            _peopleService = peopleService;
            _languageService = languageService;
        }


        // GET: LanguageController
        public ActionResult ShowLanguage()
        {
            CreateLanguageViewModel clVM = new CreateLanguageViewModel();
            clVM.LanguageList = _languageService.All();
            return View(clVM);
        }

        // GET: LanguageController/Details/5
        public ActionResult LanguageDetail(int id)
        {
            CreateLanguageViewModel clVM = new CreateLanguageViewModel();
            Language langDetails = _languageService.FindBy(id);
            clVM.LanguageID = langDetails.LanguageID;
            //clVM.PeopleList = langDetails.PeopleList;
            return View(clVM);
        }

        // GET: LanguageController/Create
        public ActionResult CreateLanguage()
        {
            CreateLanguageViewModel clVM = new CreateLanguageViewModel();
            PeopleViewModel peopleVM = new PeopleViewModel();
            peopleVM = _peopleService.All();
            clVM.PeopleList = peopleVM.AllPeople;
            return View(clVM);
        }

        // POST: LanguageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateLanguage(CreateLanguageViewModel createLanguage)
        {
            if (ModelState.IsValid)
            {
                Language language = _languageService.Add(createLanguage);


                if (language == null)
                {
                    ModelState.AddModelError("msg", "Database Problem");
                    return View(createLanguage);
                }

                return RedirectToAction(nameof(ShowLanguage));
            }
            else
            {
                return View(createLanguage);
            }
        }

        // GET: LanguageController/Edit/5
        public ActionResult EditLanguage(int id)
        {
            CreateLanguageViewModel clVM = new CreateLanguageViewModel();
            Language editLanguage = _languageService.FindBy(id);
            clVM.LanguageName = editLanguage.LanguageName;
            clVM.LanguageID= editLanguage.LanguageID;

            List<Person> allPerson = new List<Person>();
            //allPerson = _peopleService.All();
            clVM.PeopleList = allPerson;

            return View("Edit", clVM);
        }

        // POST: LanguageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditLanguage(CreateLanguageViewModel editLanguage)
        {
            _languageService.Edit(editLanguage.LanguageID, editLanguage);
            return RedirectToAction(nameof(ShowLanguage));
        }

        // GET: LanguageController/Delete/5
        public ActionResult Delete(int id)
        {
            _languageService.Remove(id);

            return RedirectToAction(nameof(ShowLanguage));
        }

        // POST: LanguageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
