using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
