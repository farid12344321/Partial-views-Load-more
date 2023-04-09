using Microsoft.AspNetCore.Mvc;

namespace Partical_views.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
