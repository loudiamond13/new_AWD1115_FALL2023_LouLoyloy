using HOT01.Models;
using Microsoft.AspNetCore.Mvc;


namespace DistanceConverter.Controllers
{
    public class DistanceConverterController : Controller
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
                ViewBag.DistanceInInches = inches.DistanceInCentimeters();

            }
            else { ViewBag.DistanceInInches = ""; }

            return View("Index", inches);
        }
    }
}
