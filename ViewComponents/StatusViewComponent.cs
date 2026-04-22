using Microsoft.AspNetCore.Mvc;

namespace PhoneWebApp.ViewComponents
{
    public class StatusViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string status)
        {
            return View("Default", status);
        }
    }
}
