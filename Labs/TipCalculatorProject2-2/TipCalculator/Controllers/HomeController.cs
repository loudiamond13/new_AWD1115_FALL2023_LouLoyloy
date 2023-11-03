using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.TwentyFive = 0.0;
            ViewBag.Twenty = 0.0;
            ViewBag.Fifteen = 0.0;
            return View();
        }


        [HttpPost]
        public IActionResult Index(Calculator calculator) 
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = calculator.CalculateTip(0.25);
                ViewBag.Twenty = calculator.CalculateTip(0.20);
                ViewBag.TwentyFive = calculator.CalculateTip(0.15);

            }
            else 
            {
                ViewBag.TwentyFive = 0.0;
                ViewBag.Twenty = 0.0;
                ViewBag.Fifteen = 0.0;
            }

            return View(calculator);
        }
      
    }
}