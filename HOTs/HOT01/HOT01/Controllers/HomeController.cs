using HOT01.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HOT01.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DistanceInInches = "";
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(DistanceConverterModel inches)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DistanceInInches =  inches.DistanceInCentimeters();

            }
            else { ViewBag.DistanceInInches = ""; }

            return View(inches);
        }

        
    }
}