using DataAccessLibrary.DataAccess.Interface;
using Microsoft.AspNetCore.Mvc;
using DataAccessLibrary;
using FinalProject.ViewModels;
using Antlr.Runtime.Tree;

namespace FinalProject.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork context { get; set; }

        public ProductController(IUnitOfWork ctx)
        { 
            context = ctx;
        }

        [HttpGet]
        [Route("products/")]
        public ViewResult List()
        {
            TempData["headerMessage"] = "All Products";

            var Products = context.Products.GetAllProducts().ToList();
            ViewBag.Products = Products;
            ViewBag.Categories = context.Categories.GetAll().ToList();
            

           
            return View(Products);
        }

        public IActionResult Details(int id) 
        {
            TempData["headerMessage"] = "Product Details";
            var product = context.Products.GetByID(id);

            return View("Details", product);
        }
    }
}
