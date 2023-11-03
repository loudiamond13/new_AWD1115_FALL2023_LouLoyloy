using BikeShop_HOT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using Category = BikeShop_HOT.Models.Category;


namespace BikeShop_HOT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {

        //constructors
        private BikeShopContext BsContext { get; set; }

        public CategoryController(BikeShopContext context) 
        {
            BsContext = context;
        }

        ProductListViewModel vm = new ProductListViewModel();
        

        [Route("/admin/category/{id?}/{Slug?}")]
        public IActionResult List()
        {
            
            
          
            //ProductListViewModel vm = new ProductListViewModel();

         

            vm.Categories = BsContext.Categories.OrderBy(cat => cat.CategoryName).ToList();


            return View("List", vm);
        }

        [Route("/admin/category/{action}/{id?}/{Slug?}")]
        [HttpGet]
        public ViewResult Update(int id) 
        {
            ViewBag.Action = "Update";
            var category = BsContext.Categories.FirstOrDefault(cat => cat.CategoryID == id);
            return View("AddUpdate",category);
        }


        [Route("/admin/category/{action}/{id?}/{Slug?}")]
        [HttpGet]
        public ViewResult Add() 
        {
            ViewBag.Action = "Add";
            return View("AddUpdate", new Category());
        }


        [Route("/admin/category/{action}/{id?}/{Slug?}")]
        [HttpPost]
        public IActionResult AddUpdate(Category category) 
        {


            // if no id is passed in, Add product, else update
            string AddUpdateCategory = (category.CategoryID == 0) ? "Add" : "Update";


            if (ModelState.IsValid)
            {
                if (AddUpdateCategory == "Add")
                {
                    TempData["message"] =
                        "Category " + category.CategoryName.ToString() + " Has Been Successfully Added To Categories.";
                    BsContext.Categories.Add(category);
                }
                else
                {
                    TempData["message"] =
                        "Category " + category.CategoryName.ToString() + " Has Been Successfully Updated.";
                    BsContext.Categories.Update(category);
                }

               
                   
                BsContext.SaveChanges();

                return RedirectToAction("List", "Category");
            }
            else 
            {
                ViewBag.Action = AddUpdateCategory;
                return View(category);
            }



        }
        

        [Route("/admin/category/{action}/{id?}/{Slug?}")]
        [HttpGet]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            

            // find the category
            var CategoryToBeGone = BsContext.Categories.Find(id);

            // if uncategorized category is passed in to be deleted, prevent it to be deleted
            //do not go anywhere
            if (id == 7)
            {
               
                ModelState.AddModelError(nameof(id), "Email not found or matched");
                TempData["deleteMSG"] = $"Deletion of {CategoryToBeGone.CategoryName} is Prohibited!";
                
                return RedirectToAction("List", id);
            }
            else 
            {
                TempData["message"] = "Category " + CategoryToBeGone?.CategoryName + " Has Been Deleted!";

                //find the related data || find where this category exist 
                var products = BsContext.Products
                    .Where(p => EF.Property<int>(p, "CategoryID") == id);

                //messsage 
                TempData["message"] = "Category " + CategoryToBeGone?.CategoryName + " Has Been Deleted!";




                //and delete it where this category exist
                foreach (var prod in products)
                {

                    // move the product into the uncategorized product
                    prod.CategoryID = 7;

                }

                //remove the category that passed in
                BsContext.Categories.Remove(CategoryToBeGone);
                BsContext.SaveChanges();



                return RedirectToAction("List", "Category");
            }






         

        }














        

    }
}
