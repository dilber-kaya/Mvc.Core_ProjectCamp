using Microsoft.AspNetCore.Mvc;

namespace _1_MvcProject_UI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
