using BikeShop_HOT.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.Drawing.Design;
using System.Formats.Asn1;
using System.Linq;

namespace BikeShop_HOT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {


        //constructors
        private BikeShopContext BsContext { get; set; }

        public ProductController(BikeShopContext context)
        {
            BsContext = context;
        }


        public void BikeShopLists()
        {
            ViewBag.Products = BsContext.Products.Include(prod => prod.Category)
                                                    .OrderBy(prod => prod.Name)
                                                    .ToList();


            ViewBag.Categories = BsContext.Categories.OrderBy(cat => cat.CategoryName).ToList();
        }
        


        [Route("/admin/products/{id?}/{Slug?}")]

        public ViewResult List(int id)
        {
            ProductListViewModel viewModel = new ProductListViewModel();
            ViewBag.cName = "";

            viewModel.SelectedCategory = id;

            
            
            // all products to List
            viewModel.Products =  BsContext.Products.OrderBy(prod => prod.Name).ToList();
            // all categories to List
          
            viewModel.Categories = BsContext.Categories.OrderBy(cat => cat.CategoryName).ToList();






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



        [Route("/admin/product/update/{id?}/{Slug?}")]
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Action = "Update";

            // list viewbag
            BikeShopLists();

            //search the selected product to update
            var product =   BsContext.Products.Include(prod => prod.Category)
                                            .FirstOrDefault(prod => prod.ProductID == id);

            TempData["subheader"] = "Updating " + product?.Name + " Data.";
            return View("AddUpdate", product);

        }

        //[Route("/admin/product/add/")]
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            // categories viewbag
           ViewBag.Categories = BsContext.Categories.OrderBy(cat => cat.CategoryName).ToList();
           
            TempData["subheader"] = "Add New Product.";
            return View("AddUpdate", new Product());
        }

        [Route("/admin/product/{action}/")]
        [HttpPost]
        public IActionResult AddUpdate(Product product) 
        {
            
            string AddUpdate = (product.ProductID == 0) ? "Add" : "Update";

            if (ModelState.IsValid)
            {
                if (AddUpdate == "Add")
                {
                    TempData["message"] = product.Name.ToString() + " Has Been Added To The Products";
                    BsContext.Products.Add(product);
                    
                }
                else
                {
                    // message when updated
                    TempData["message"] = product.Name.ToString() + " Has Been Successfully Updated";
                    BsContext.Products.Update(product);
                }
                BsContext.SaveChanges();

                return RedirectToAction("List", "Product");
            }

            else 
            {
                BikeShopLists();
                ViewBag.Action = AddUpdate;
                return View(product);
            }
            
        }

        [Route("/admin/products/delete/{id?}/{slug?}")]
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            TempData["subheader"] = "Confirm Product Deletion";
            var product = BsContext.Products.Find(id);
            return View(product);
        }

        [Route("/admin/products/delete/{id?}/{slug?}")]
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            string name = product.Name;
            TempData["message"] = "Product " + name + " Has Been Deleted.";
            BsContext.Products.Remove(product);
            BsContext.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
