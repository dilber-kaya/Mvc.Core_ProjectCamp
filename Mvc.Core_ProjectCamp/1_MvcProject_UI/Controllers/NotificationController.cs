using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManagerBL nm = new NotificationManagerBL(new EFNotificationRepository());

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AllNotifications()
        {
            var values = nm.ListBL();
            return View(values);
        }
    }
}
