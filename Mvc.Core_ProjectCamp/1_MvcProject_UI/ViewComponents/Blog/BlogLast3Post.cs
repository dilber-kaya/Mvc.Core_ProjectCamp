using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Blog
{
    public class BlogLast3Post:ViewComponent
    {

        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3BlogBL();
            return View(values);
        }
    }
}
