using Microsoft.AspNetCore.Mvc;
using MVC_TIME.Models;

namespace MVC_TIME.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // returns the view in the Views >> Home >> Index.cshtml location
            return View();
        }
        [HttpPost]
        public IActionResult Index(int startyear, int endyear)
        {
            return RedirectToAction("Results", new { startyear, endyear });
        }
        [HttpGet]
        public IActionResult Results(int startyear, int endyear)
        {
           
            return View(TimePerson.GetPerson(startyear, endyear));        
        }
       
      
    }
}
