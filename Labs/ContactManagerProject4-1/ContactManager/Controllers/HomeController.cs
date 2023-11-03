using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        
        private ContactContext context { get; set; }

        //constructor
        public HomeController(ContactContext ctxt)
        { 
            context = ctxt;
        }


        public IActionResult Index()
        {
            var contacts = context.Contacts.Include(cont => cont.Category )
                                            .OrderBy(cont => cont.FirstName)
                                            .ToList();


            return View(contacts);
        }

      
    }
}