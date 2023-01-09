using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
	public class AboutController : Controller
	{
		AboutManagerBL abm = new AboutManagerBL(new EFAboutRepository());
		public IActionResult Index()
		{
			var values = abm.ListAboutBL();
			return View(values);
		}
		public PartialViewResult SocialMediaAbout()
		{

			return PartialView();
		}
	}
}
