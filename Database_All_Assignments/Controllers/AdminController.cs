using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_All_Assignments.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Database_All_Assignments.Controllers
{
    [Authorize(Roles= "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<ContentUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdminController(UserManager<ContentUser> userManager, RoleManager<IdentityRole>roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
        public async Task<IActionResult> AddAdmin(string id)
        {
            ContentUser contentUser = await _userManager.FindByIdAsync(id);

            if (contentUser != null)
            {
                var result= await _userManager.AddToRoleAsync(contentUser, "Admin");
            }
                return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveAdmin(string id)
        {
            ContentUser contentUser = await _userManager.FindByIdAsync(id);

            if (contentUser != null && contentUser.UserName != "SuperAdmin")
            {
                var result= await _userManager.RemoveFromRoleAsync(contentUser, "Admin");
            }
                return RedirectToAction("Index");
        }
    }
}
