using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using System.Collections.Generic;



namespace SportsPro.Controllers
{
    public class IncidentController : Controller
    {
        private SportsProContext spContext { get; set; }

        public IncidentController(SportsProContext context)
        {
            spContext = context;
        }



        
        [Route("/incidents")]
        public IActionResult List()
        {
            ViewBag.Technicians = spContext.Technicians.ToList();
            ViewBag.Customers = spContext.Customers.ToList();
            ViewBag.Products = spContext.Products.ToList();
            var incidents = spContext.Incidents.OrderBy(incident => incident.DateOpened)
                                                .ToList();

            return View(incidents);
        }

        
        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Action = "Add";
            ViewBag.Technicians = spContext.Technicians.ToList();
            ViewBag.Customers = spContext.Customers.ToList();
            ViewBag.Products = spContext.Products.ToList();

            return View("AddEdit", new Incident());
        }

        [Route("/incidents/edit/id/{id?}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Technicians = spContext.Technicians.ToList();
            ViewBag.Customers = spContext.Customers.ToList();
            ViewBag.Products = spContext.Products.ToList();

            var incident = spContext.Incidents.Find(id);

            return View("AddEdit", incident);
        }

        [HttpPost]
        public IActionResult Save(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.IncidentID > 0)
                {
                    spContext.Incidents.Update(incident);
                }
                else
                {
                    spContext.Incidents.Add(incident);
                }

                spContext.SaveChanges();

                return RedirectToAction("List", "Incident");
            }
            else
            {
                
                ViewBag.Technicians = spContext.Technicians.ToList();
                ViewBag.Customers = spContext.Customers.ToList();
                ViewBag.Products = spContext.Products.ToList();

                return View("AddEdit", incident);

            }

            
        
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = spContext.Incidents.Find(id);
            return View(incident); 
        }

        [HttpPost]
        public IActionResult Delete(Incident incident) 
        {
            spContext.Incidents.Remove(incident);
            spContext.SaveChanges();
            return View("List","Incident");
        }
    }
}
