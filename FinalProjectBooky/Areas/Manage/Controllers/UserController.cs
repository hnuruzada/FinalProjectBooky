using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    //[Authorize(Roles = "SuperAdmin")]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserController(UserManager<AppUser> userManager, AppDbContext context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Users.Count() / 6);
            ViewBag.CurrentPage = page;
            List<AppUser> user = _userManager.Users.Skip((page - 1) * 6).Take(6).ToList();

            return View(user);
        }
        public async Task<IActionResult> UserStatusChange(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user.IsAdmin==null)
            {
                user.IsAdmin = false;
              

                await _userManager.RemoveFromRoleAsync(user, "Member");
                await _userManager.AddToRoleAsync(user, "Publisher");

            }
            else if(user.IsAdmin==false )
            {
                user.IsAdmin = true;
                
                await _userManager.RemoveFromRoleAsync(user, "Publisher");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            else if(user.IsAdmin == true )
            {
                user.IsAdmin = null;
               
                await _userManager.RemoveFromRoleAsync(user, "Admin");

                await _userManager.AddToRoleAsync(user, "Member");
            }
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
