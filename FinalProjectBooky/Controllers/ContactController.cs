using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
