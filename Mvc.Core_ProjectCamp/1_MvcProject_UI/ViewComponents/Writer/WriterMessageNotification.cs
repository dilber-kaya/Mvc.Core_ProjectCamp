using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        Message2ManagerBL mm = new Message2ManagerBL(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
