using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
	public class CommentController : Controller
	{
		CommentManagerBL cm = new CommentManagerBL(new EFCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
		[HttpPost]

		public PartialViewResult PartialAddComment(Comment p)
		{
			p.CommentDate= DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 8;
			cm.AddCommentBL(p);
			return PartialView();
		}
		public PartialViewResult CommentListFromBlog(int id)
		{
			var values = cm.ListCommentBL(id);
			return PartialView(values);
		}
	}
}
