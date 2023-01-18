using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
