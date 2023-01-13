using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
    public class DashboardController : Controller
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());

        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c= new Context();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x=>x.WriterID==1).Count().ToString();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
