using Microsoft.AspNetCore.Mvc;
using BikeShop_HOT.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Routing;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using ProductListViewModel = BikeShop_HOT.Models.ProductListViewModel;
using Microsoft.AspNetCore.Authentication;

namespace BikeShop_HOT.Controllers
{
    public class ProductController : Controller
    {
        private BikeShopContext BsProdContext { get; set; }

        public ProductController(BikeShopContext ctx)
        {
            BsProdContext = ctx;
        }




      [Route("/products/{id?}/{Slug?}")]     
        public ViewResult List(int id)
        {
            var viewModel = new ProductListViewModel();
            ViewBag.cName = "";

            viewModel.SelectedCategory = id;



            // all products to List
            viewModel.Products = BsProdContext.Products.OrderBy(prod => prod.Name).ToList();
            // all categories to List

            viewModel.Categories = BsProdContext.Categories.OrderBy(c => c.CategoryName).ToList();






            // if no selected category show all products
            if (id == null || id == 0)
            {
                // set the temp subheader
                TempData["subheader"] = "ALL PRODUCTS";
                return View("List", viewModel);
            }
            else
            {

                // search for the seleted category
                viewModel.Products = viewModel.Products.Where(c => c.CategoryID == id)
                                                        .OrderBy(c => c.Category.CategoryName)
                                                        .ToList();



                // set the temp subheader
                ViewBag.cName = viewModel.Categories.FirstOrDefault(c => c.CategoryID == id)?.CategoryName?.ToString();
                TempData["subheader"] = ViewBag.cName;

                return View("List", viewModel);

            }
            


            
        }



        [Route("product/details/{id?}/{Slug?}")]
        
        public IActionResult Details(int id)
        {
            


            var product = BsProdContext.Products.Include(prod => prod.Category)
                                                .FirstOrDefault(prod => prod.ProductID == id);
            
            return View("Details", product);
        }


        [Route("/cart/id/{id?}/{Slug?}")]
        [HttpGet]
        public IActionResult Cart(int id)
        {

            var product = BsProdContext.Products.Include(prod => prod.Category)
                                                .FirstOrDefault(prod => prod.ProductID == id);

            return View("Cart",product);
        }





    }
}
