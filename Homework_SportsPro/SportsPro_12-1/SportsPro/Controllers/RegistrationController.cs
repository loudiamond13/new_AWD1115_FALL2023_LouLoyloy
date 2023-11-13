using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using SportsPro.Models.ViewModels;
using SportsPro.Repositories.Interfaces;
using System.Linq;

namespace SportsPro.Controllers
{
    public class RegistrationController : Controller
    {
        private IUnitOfWork spContext { get; set; }
        private SportsProContext context;

        public RegistrationController(IUnitOfWork context, SportsProContext cont)
        {
            spContext = context;
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            ViewBag.Customers = spContext.Customers.GetAll().OrderBy(c => c.LastName).ToList();

            int custID = HttpContext.Session.GetInt32("custID") ?? 0;
            Customer customer;

            if (custID == 0)
            { 
                customer = new Customer();
            }
            else 
            {
                customer = spContext.Customers.GetByID(custID);
               
            }

            return View(customer);
        }

        //
        //public IActionResult GetCustomer() 
        //{
        //    ViewBag.Customers = spContext.Customers.GetAll().OrderBy(c => c.LastName).ToList();

        //    int custID = HttpContext.Session.GetInt32("custID") ?? 0;
        //    Customer customer;
        //}
      



        [HttpGet]
        [Route("[controller]s/id/{id}")]
        public IActionResult List(int id)
        {
            RegistrationViewModel viewModel = new RegistrationViewModel()
            {
                CustomerID = id,
                Customer = spContext.Customers.GetByID(id),
                Products = spContext.Products.GetAll().ToList(),
                Registrations = spContext.Registrations.GetAllRegistrationsIncludesAll()
                                                        .Where(r => r.CustomerID == id)
                                                        .ToList()
            };

            return View(viewModel); 
        }

        [HttpPost]
        [Route("[controller]s")]
        public IActionResult List(Customer customer)
        {
            HttpContext.Session.SetInt32("custID", customer.CustomerID);

            if (customer.CustomerID == 0)
            {
                TempData["negativeMessage"] = "You Must Select A Customer.";
                return RedirectToAction("GetCustomer");
            }
            else
            {
                return RedirectToAction("List", new { id = customer.CustomerID });
            }
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel viewModel)
        {
            if (viewModel.ProductID == 0)
            {
                TempData["negativeMessage"] = "You Must Select A Product.";
            }
            else 
            {
                Registration registration = new Registration()
                {
                    CustomerID = viewModel.CustomerID,
                    ProductID = viewModel.ProductID,
                };

                spContext.Registrations.Add(registration);

                try 
                {
                    spContext.Complete();
                }
                catch(DbUpdateException ex)
                {
                    string message = (ex.InnerException == null) ?
                                        ex.Message : ex.InnerException.Message.ToString();

                    if (message.Contains("duplicate key"))
                    {
                        TempData["negativeMessage"] = $"This Product Is Already Registered To This Customer.";
                    }
                    else
                    {
                        TempData["negativeMessage"] = $"Error Accessing Database: {message}";
                    }
                    
                }
                
            }
            return RedirectToAction("List", new { id = viewModel.CustomerID });
        }

    
        [HttpPost]
        public IActionResult Delete(int productID, int customerID) 
        {
           Product product = spContext.Products.GetByID(productID);
            


            Registration registration = new Registration()
            {

                CustomerID = customerID,
                ProductID = productID
            };

          
            TempData["message"] = $"Product '{product.Name}' Has Been Successfully Deleted.";

            spContext.Registrations.Delete(registration);
            spContext.Complete();
           
            
            return RedirectToAction("List", new { id = customerID});
        }

    }
}
