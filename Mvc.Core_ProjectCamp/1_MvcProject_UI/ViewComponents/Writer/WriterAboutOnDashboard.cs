using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManagerBL wm = new WriterManagerBL(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = wm.GetWriterByIdBL(1);
            return View(values);
        }
    }
}
