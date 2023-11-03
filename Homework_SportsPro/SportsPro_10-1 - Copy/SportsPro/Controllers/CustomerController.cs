using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class CustomerController : Controller
    {
        private SportsProContext spContext { get; set; }

        //constructor
        public CustomerController(SportsProContext context)
        { 
            spContext = context;
        }

        [Route("/customers")]
        public IActionResult List()
        {
            var customers = spContext.Customers.OrderBy(cust => cust.FirstName)
                                                .ToList();
            return View(customers);
        }

        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = spContext.Countries.ToList();

            return View("AddEdit",new Customer());
        }

        [Route("/customers/edit/id/{id?}")]
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            ViewBag.Countries = spContext.Countries.ToList();
            ViewBag.Action = "Edit";

            var customer = spContext.Customers.Find(id);

            return View("AddEdit",customer);


        }

        [HttpPost]
        public IActionResult AddEdit(Customer customer) 
        {
            if (ModelState.IsValid)
            {
                if (customer.CustomerID > 0)
                {
                    spContext.Customers.Update(customer);
                }
                else
                {
                    spContext.Customers.Add(customer);

                }

                spContext.SaveChanges();

                return RedirectToAction("List", "Customer");
            }
            else 
            {
                ViewBag.Countries = spContext.Countries.ToList();
                return View("AddEdit", customer);
            }
        
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var customer = spContext.Customers.Find(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Delete(Customer customer) 
        {
            spContext.Customers.Remove(customer);
            spContext.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
    }
}
