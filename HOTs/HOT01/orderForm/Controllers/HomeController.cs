﻿using Microsoft.AspNetCore.Mvc;
using orderForm.Models;
using System.Diagnostics;
using orderForm;

namespace orderForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            
            ViewBag.PricePerShirt = "";
            ViewBag.DiscountCodeMessage = "";
            ViewBag.Tax = 0;
            ViewBag.Subtotal = 0;
            ViewBag.Total = 0;
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderForm form)
        {
            if (ModelState.IsValid)
            {
                ViewBag.PricePerShirt = form.CalculatePricePerShirtString();
                ViewBag.Subtotal = form.CalculateSubtotal().ToString("c2");
                ViewBag.Total = form.CalculateTotal().ToString("c2");
                ViewBag.DiscountCodeMessage = form.DiscountMessage();
                ViewBag.Tax = form.CalculateTax().ToString("c2");
            }
            else 
            {
               
                ViewBag.PricePerShirt = "";
                ViewBag.DiscountCode = "";
                ViewBag.Tax = 0.ToString("c2");
                ViewBag.Subtotal = 0.ToString("c2");
                ViewBag.Total = 0.ToString("c2");
               
            }
            
            return View(form);
        }

        
    }
}