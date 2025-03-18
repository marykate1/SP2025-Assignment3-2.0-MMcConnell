using Microsoft.AspNetCore.Mvc;

namespace SP2025_Assignment3_2._0_MMcConnell.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("IndexHome");
        }
    }
}
