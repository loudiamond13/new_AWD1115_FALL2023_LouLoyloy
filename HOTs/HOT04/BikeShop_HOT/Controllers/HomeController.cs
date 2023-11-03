using BikeShop_HOT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BikeShop_HOT.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

       
    }
}