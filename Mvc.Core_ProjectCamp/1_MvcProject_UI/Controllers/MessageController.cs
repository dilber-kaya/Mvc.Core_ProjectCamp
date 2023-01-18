using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _1_MvcProject_UI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2ManagerBL mm = new Message2ManagerBL(new EFMessage2Repository());
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = mm.GetByIdBL(id);
            return View(value);
        }
    }
}
