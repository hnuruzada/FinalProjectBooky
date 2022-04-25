using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInResult;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInResult)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInResult = signInResult;

        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (login.Username == null)
            {
                ModelState.AddModelError("", "name or pasword incorrect");
                return View();
            }
            if (login.Password == null)
            {
                ModelState.AddModelError("", "name or pasword incorrect");
                return View();
            }
            if (!ModelState.IsValid) return View();
            AppUser user = await _userManager.FindByNameAsync(login.Username);

            if (user.IsAdmin == null)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }

            if (user == null)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInResult.PasswordSignInAsync(user, login.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password incorrect");
                return View();
            }

            if(User.IsInRole("SuperAdmin") || User.IsInRole("Admin"))
            {
                return RedirectToAction("index", "dashboard");
            }
            else if(User.IsInRole("Publisher"))
            {
                return RedirectToAction("index", "blog");
            }

            return StatusCode(200);

            

        }
        public async Task<IActionResult> Logout()
        {
            await _signInResult.SignOutAsync();
            return RedirectToAction("login", "account");
        }
        //public async Task CreateRole()
        //{
        //    await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        //    await _roleManager.CreateAsync(new IdentityRole("Admin"));
        //    await _roleManager.CreateAsync(new IdentityRole("Publisher"));
        //    await _roleManager.CreateAsync(new IdentityRole("Member"));
        //}

        //public async Task CreateAdmin()
        //{
        //    AppUser user = new AppUser
        //    {
        //        UserName = "HasanNuruzade",
        //        Email = "h.nuruzada@hotmail.com",
        //        Name = "Hasan",
        //        Surname = "Nuruzada"

        //    };

        //    await _userManager.CreateAsync(user, "Hasan12345@");
        //    await _userManager.AddToRoleAsync(user, "SuperAdmin");

        //}
    }
}
