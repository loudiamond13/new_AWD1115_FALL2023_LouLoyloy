using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using System.Linq;

namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {
        private SportsProContext spContext { get; set; }

        //constructor
        public ProductController(SportsProContext context)
        {
            spContext = context;
        }


        [Route("/products")]
        public IActionResult List()
        {
            //List<Product>
            var products = spContext.Products.OrderBy(prod => prod.ReleaseDate)
                                                        .ToList();
            return View("List", products);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";

            //return the AddEdit View With a new/empty product context
            return View("AddEdit", new Product());
        }


        [Route("/products/edit/id/{id?}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            
            //find the passed in product id
            var product = spContext.Products.Find(id);

            //  
            return View("AddEdit",product);
        }

        [Route("/products/{action?}/id/{id?}")]
        [HttpPost]
        public IActionResult AddEdit(Product product) 
        {
            if (ModelState.IsValid)
            {
                if (product.ProductID == 0)
                {
                    
                    spContext.Products.Add(product);

                    // Add custom message when a product is added.
                    TempData["message"] = $"Successfully Added  '{product.Name}' to Products.";
                }
                else
                {
                   
                    
                    spContext.Products.Update(product);

                    // Add custom message when a product is updated.
                    TempData["message"] = " '"+product.Name +"'" + " Has Been updated.";
                        
                
                }

                spContext.SaveChanges();

                return RedirectToAction("List", "Product");
            }
            else 
            {
                if (product.ProductID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                { 
                    ViewBag.Action = "Edit"; 
                }

                return View("AddEdit",product);
            }
        }

        [Route(("/products/{action?}/id/{id?}"))]
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var product = spContext.Products.Find(id);
            
            ViewBag.asd = product.Name;

            return View(product);
        }

        [Route(("/products/{action?}/id/{id?}"))]
        [HttpPost]
        public IActionResult Delete(Product product) 
        {



            // Add custom message 
            TempData["message"] = $"Product with ID: {product.ProductID} has been deleted.";


            spContext.Products.Remove(product);
           
            spContext.SaveChanges();
          
            return RedirectToAction("List", "Product");
           
        }
    }
}
