using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
    public class Category : Controller
    {
        CategoryManagerBL cm = new CategoryManagerBL(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.ListBL();
            return View(values);
        }
    }
}
