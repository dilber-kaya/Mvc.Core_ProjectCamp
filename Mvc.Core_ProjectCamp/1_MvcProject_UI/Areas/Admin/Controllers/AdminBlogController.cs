using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBlogController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategoryBL();
            return View(values);
        }
    }
}
