using BikeShopHOT02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BikeShopHOT02.Controllers
{
    public class ProductController : Controller
    {

        //ProductContext private variable
        private BikeShopContext productContext { get; set; }


        //productController Constructor
        public ProductController(BikeShopContext context)
        {
            productContext = context;
        }


        //List.cshtml Controller
        public IActionResult List()
        {
            //initialize product variable with product data's into List, including category
            var products = productContext.Products
                .Include(c => c.Category)
                .OrderBy(c => c.ProductName).ToList();


            return View(products);
        }


        // edit action
        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            //initialize a viewbag for action
            ViewBag.Action = "Edit Product";

            // initialize a viewbag for the product categories for the drow down list(edit action)
            ViewBag.Categories = productContext.Categories.OrderBy(prod => prod.CategoryDescription)
                                                          .ToList();

            //create a variable and store the data of the selected product based on the ID that is passed in
            var product = productContext.Products.Include(prod => prod.Category)
                                                    .FirstOrDefault(prod => prod.ProductID == id);

            //return the chosen product using the AddEdit View
            return View("AddEdit", product);
        }


        // add action
        [HttpGet]
        public IActionResult AddProduct()
        {
            // initialize a viewbag for action
            ViewBag.Action = "Add Product";

            // initialize a viewbag for the product categories for the drow down list(add action)
            ViewBag.Categories = productContext.Categories.OrderBy(prod => prod.CategoryDescription)
                                                            .ToList();

            //return the AddEdit View with a new product(empty product)
            return View("AddEdit", new Product());
        }


        //post method for add||edit
        [HttpPost]
        public IActionResult AddEdit(Product product)
        {
            // product has no ID || Product ID == 0, set action to add
            //else if there is a product ID, set action to edit
            string action = (product.ProductID == 0) ? "Add Product" : "Edit Product";

            if (ModelState.IsValid)
            {
                // if action is EditProduct, Update/Edit the chosen product
                if (action == "Edit Product")
                {
                    //update the chosen product
                    productContext.Products.Update(product);

                }
                else  // else if action is AddProduct, Add product
                {
                    //add new product into the database
                    productContext.Products.Add(product);
                }

                // save changes
                productContext.SaveChanges();

                // return to the List view
                return RedirectToAction("List", "Product");
            }
            else // else if entries are not valid do not go anywhere
            {

                ViewBag.Action = action;
                ViewBag.Categories = productContext.Categories.OrderBy(prod => prod.CategoryDescription)
                                                            .ToList();

                return View(product);
            }
        }

        //get method for delete action
        [HttpGet]
        public IActionResult DeleteProduct(int id) 
        {
            ViewBag.Action = "Delete Product";

            //create a variable and store the data of the selected product based on the ID that is passed in
            var product = productContext.Products.Include(prod => prod.Category)
                                                .FirstOrDefault(prod => prod.ProductID == id);
            //return the selected product 
            return View("Delete",product);
        }

        //post method for delete action
        [HttpPost]
        public IActionResult DeleteProduct(Product product) 
        {
            //delete/remove the selected product
            productContext.Products.Remove(product);
            productContext.SaveChanges();

            //return to the list view
            return RedirectToAction("List", "Product");
        }
    }
}
