using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using System.Diagnostics;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        

        public IActionResult About() 
        {
            return View();
        }

       
    }
}