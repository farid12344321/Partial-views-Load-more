using Microsoft.AspNetCore.Mvc;

namespace Partical_views.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
