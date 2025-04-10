using Microsoft.AspNetCore.Mvc;

namespace Almajed_Services_Website.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
