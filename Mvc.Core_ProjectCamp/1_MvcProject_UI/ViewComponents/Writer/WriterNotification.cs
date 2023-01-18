using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManagerBL nm = new NotificationManagerBL(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.ListBL();
            return View(values);
        }
    }
}
