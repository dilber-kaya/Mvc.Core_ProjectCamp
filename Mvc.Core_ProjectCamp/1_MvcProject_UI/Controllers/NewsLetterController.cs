using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManagerBL nm = new NewsLetterManagerBL(new EFNewsLetterRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
            p.MailStatus = true;
            nm.AddNewsLetterBL(p);
            return PartialView();
        }
    }
}
