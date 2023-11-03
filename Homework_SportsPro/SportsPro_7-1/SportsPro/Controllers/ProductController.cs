using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

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
            return View(products);
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

        [HttpPost]
        public IActionResult Save(Product product) 
        {
            if (ModelState.IsValid)
            {
                if (product.ProductID == 0)
                {
                    spContext.Products.Add(product);
                }
                else
                {
                    spContext.Products.Update(product);
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

                return View(product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var product = spContext.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product) 
        { 
            spContext.Products.Remove(product);
            spContext.SaveChanges();
            return RedirectToAction("List");
        }
    }
}
