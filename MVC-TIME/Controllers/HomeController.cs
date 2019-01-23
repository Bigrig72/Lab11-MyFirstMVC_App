using Microsoft.AspNetCore.Mvc;

namespace MVC_TIME.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int beginyear, int endyear)
        {
            return RedirectToAction("Results", new { beginyear, endyear });           
        }
      
    }
}
