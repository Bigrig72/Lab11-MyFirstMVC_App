using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_TIME.Models;

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
        public IActionResult Results()
        {
            TimePerson person = new TimePerson();
            return View(person);
        }
    }
}
