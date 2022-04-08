using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
