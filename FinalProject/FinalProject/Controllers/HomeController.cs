using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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