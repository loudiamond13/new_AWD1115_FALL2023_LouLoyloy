using BikeShopHOT02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BikeShopHOT02.Controllers
{
    public class HomeController : Controller
    {
        private BikeShopContext productContext { get; set; }

        public HomeController(BikeShopContext context)
        {
            productContext = context;
        }



        public IActionResult Index()
        {
            

            return View();

            
        }

      
    }
}