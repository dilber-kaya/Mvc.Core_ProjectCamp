using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManagerBL cm = new CommentManagerBL(new EFCommentRepository());
        public IActionResult Index()
        {
            var values = cm.GetCommentListWithBlogBL();
            return View(values);
        }
    }
}
