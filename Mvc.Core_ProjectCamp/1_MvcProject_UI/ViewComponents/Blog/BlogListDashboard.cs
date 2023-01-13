using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategoryBL();
            return View(values);
        }
    }
}
