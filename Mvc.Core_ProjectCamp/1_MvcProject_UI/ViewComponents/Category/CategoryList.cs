using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Category
{
	public class CategoryList:ViewComponent
	{
		CategoryManagerBL cm = new CategoryManagerBL(new EFCategoryRepository());

		public IViewComponentResult Invoke()
		{
			var values = cm.ListBL();
			return View(values);
		}
	}
}
