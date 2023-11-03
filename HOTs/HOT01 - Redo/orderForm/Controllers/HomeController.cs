using Microsoft.AspNetCore.Mvc;
using orderForm.Models;
using System.Diagnostics;
using orderForm;

namespace orderForm.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet]

        public IActionResult Index()
        {
            
            
            
            return View();
        }

        

        
    }
}