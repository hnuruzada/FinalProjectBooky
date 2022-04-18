using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class WishListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
