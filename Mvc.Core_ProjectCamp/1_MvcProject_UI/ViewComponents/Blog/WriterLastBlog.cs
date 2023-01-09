using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Blog
{
	public class WriterLastBlog:ViewComponent
	{
		BlogManagerBL bm = new BlogManagerBL(new EFBlogRepository());

		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListWithWriterBL(1);
			return View(values);
		}
	}
}
