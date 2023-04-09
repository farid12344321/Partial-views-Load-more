using Microsoft.AspNetCore.Mvc;

namespace Partical_views.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
