using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;
using Microsoft.EntityFrameworkCore;



namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        //constructor
        public ContactController(ContactContext ctxt)
        {
            context = ctxt;

        }

        public IActionResult Details(int id)
        {
            var contacts = context.Contacts.Include(cont => cont.Category)
                                            .FirstOrDefault(cont => cont.ContactID == id);


            return View(contacts);
        }


        // add record
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = context.Categories.OrderBy(cont => cont.CategoryName)
                                                    .ToList();

            return View("Edit", new Contact());

        }


        // edit or update existing record
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(cont => cont.CategoryName)
                                                    .ToList();

            var contacts = context.Contacts.Include(cont => cont.Category)
                                           .FirstOrDefault(cont => cont.ContactID == id);

            return View(contacts);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            string action = (contact.ContactID == 0) ? "Add" : "Edit";

            //validate required fields
            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    contact.DateAdded = DateTime.Now;
                    context.Contacts.Add(contact);

                }
                else// action is edit
                {
                    context.Contacts.Update(contact);
                }

                //save changes
                context.SaveChanges();


                // return to homepage
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = action;
                ViewBag.Categories = context.Categories.OrderBy(cont => cont.CategoryName)
                                                        .ToList();

                return View(contact);
            }

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Include(cont => cont.Category)
                                            .FirstOrDefault(cont => cont.ContactID == id);


            return View(contact);

        }

        [HttpPost]
        public IActionResult Delete(Contact contact) 
        {
            context.Contacts.Remove(contact);
            context.SaveChanges(true);

            return RedirectToAction("Index", "Home");
        }

    }
}
