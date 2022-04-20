using FinalProjectBooky.DAL;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;
        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashboardVM dashboardVM = new DashboardVM
            {
                Books = _context.Books.Include(b => b.Comments).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(b => b.Campaign).ToList(),
                Orders = _context.Orders.ToList(),
                AppUsers=_context.Users.ToList(),
                Contacts=_context.Contacts.ToList(),
                Comments=_context.Comments.ToList(),
            };
            return View(dashboardVM);
        }
    }
}
