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

namespace BikeShop_HOT.Controllers
{
    public class ProductController : Controller
    {
        private BikeShopContext BsProdContext { get; set; }

        public ProductController(BikeShopContext ctx)
        {
            BsProdContext = ctx;
        }

       
        
        [Route("/products/{id?}/{slug?}")]     
        public IActionResult List(string id)
        {
            int? routeID = 0;
            List<Product> products = BsProdContext.Products.Include(prod => prod.Category)
                                                                                        .OrderBy(prod => prod.Name)
                                                                                        .ToList();
            if (id == "all" || id == "" || id == null)
            {

                ViewBag.Action = "All Products";
                    return View("List", products);
                }

            
            switch (id) 
            {
               
                case "accessories":
                    ViewBag.Action = "Accessories";
                    routeID = 1;
                        break;
                case "bikes":
                    ViewBag.Action = "Bikes";
                    routeID = 2;
                    break;
               case "clothing":
                    ViewBag.Action = "Clothing";
                    routeID = 3;
                    break;
                case "components":
                    ViewBag.Action = "Components";
                    routeID = 4;
                    break;
                case "car-racks":
                    ViewBag.Action = "Car Racks";
                    routeID = 5;
                    break;
                case "wheels":
                    ViewBag.Action = "Wheels";
                    routeID = 6;
                    break;
               
                default:
                    break;
            }


            products = BsProdContext.Products.Where(prod => prod.CategoryID == routeID)
                                                                                        .OrderBy(prod=>prod.Name)
                                                                                        .ToList();

            
            return View("List",products);
        }

        [Route("/product/details/{id?}")]
        [HttpGet]
        public IActionResult Details(int id)
        { 

            var product = BsProdContext.Products.Include(prod => prod.Category)
                                                                        .FirstOrDefault(prod => prod.ProductID == id);
            
            return View(product);
        }

        [Route("/cart/id/{id?}")]
        [HttpGet]
        public IActionResult Cart(int id)
        {

            var product = BsProdContext.Products.Include(prod => prod.Category)
                                                                        .FirstOrDefault(prod => prod.ProductID == id);

            return View(product);
        }





    }
}
