using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Comment
{
    public class CommentListFromBlog : ViewComponent
    {
        CommentManagerBL cm = new CommentManagerBL(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.ListCommentBL(id);
            return View(values);
        }
    }
}
