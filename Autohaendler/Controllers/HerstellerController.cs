using Microsoft.AspNetCore.Mvc;

namespace Autohaendler.Controllers
{
    public class HerstellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
