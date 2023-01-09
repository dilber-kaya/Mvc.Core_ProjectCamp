using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Error1(int code)
		{
			return View();
		}
	}
}
