using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategoryBL();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id = id;
            var values = bm.GetBlogByIdFilterBL(id);
            return View(values);
        }
    }
}
