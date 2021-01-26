using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_All_Assignments.Models.Identity;
using Database_All_Assignments.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Database_All_Assignments.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<ContentUser> _userManager;

        private readonly SignInManager<ContentUser> _signInManager;

        public AccountController(UserManager<ContentUser> userManager, SignInManager<ContentUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(IdentityLoginViewModel identityLogin)
        {
            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(identityLogin.UserName, identityLogin.Password, false,false); //username, password, persistlogin, logout

                if (result.Succeeded)
                {
                    return RedirectToAction("Add_View_People", "People");
                }

                ViewBag.Msg = "Failed to login.";
            

            }
            return View(identityLogin);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> SignUp(IdentityCreateViewModel identityCreate , string firstName, string lastName, DateTime birthDate)
        {
            if (ModelState.IsValid)
            {

                ContentUser contentUser = new ContentUser();
                contentUser.UserName = identityCreate.UserName;
                contentUser.FirstName = firstName;
                contentUser.LastName = lastName;
                contentUser.BirthDate = birthDate;
                var result = await _userManager.CreateAsync(contentUser, identityCreate.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }

                ViewBag.Msg = "Failed to sign up.";

            }

            return View(identityCreate);
        }

            //[Authorize] not needed here because the controller is already set to authorize. 
            public async Task<IActionResult> LogoutAsync()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Add_View_People", "People");
            }
    }   
    
}
