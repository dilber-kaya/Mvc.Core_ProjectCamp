using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManagerBL wm = new WriterManagerBL(new EFWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterByIdBL(writerID);
            return View(values);
        }
    }
}
