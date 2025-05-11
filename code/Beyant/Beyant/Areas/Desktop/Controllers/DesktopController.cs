using Microsoft.AspNetCore.Mvc;

namespace Beyant.Areas.Desktop.Controllers
{
    public class DesktopController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
