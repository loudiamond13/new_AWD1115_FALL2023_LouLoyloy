using HOT01.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HOT01.Controllers
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