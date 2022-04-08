using Microsoft.AspNetCore.Mvc;

namespace FinalProjectBooky.Controllers
{
    public class ViewCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
