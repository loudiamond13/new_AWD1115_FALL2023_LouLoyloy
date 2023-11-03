using Microsoft.AspNetCore.Mvc;
using PriceQuotationn.Models;
using System.Diagnostics;

namespace PriceQuotationn.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0.0;
            ViewBag.Total = 0.0;
            return View();
        }


        [HttpPost]
        public IActionResult Index(Quotation quote)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = quote.CalculateDiscount();
                ViewBag.Total = quote.CalculateTotal();
            }
            else 
            {
                ViewBag.Discount = 0.0;
                ViewBag.Total = 0.0;
            }
            return View(quote);
        
        }

       
    }
}