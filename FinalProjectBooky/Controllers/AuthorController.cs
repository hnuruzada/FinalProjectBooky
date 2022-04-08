using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
