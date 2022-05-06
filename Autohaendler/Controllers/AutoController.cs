using Microsoft.AspNetCore.Mvc;

namespace Autohaendler.Controllers
{
    public class AutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
