using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;
using SportsPro.ViewModel;
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

		IncidentViewModel vm = new IncidentViewModel();
	
		public void IncidentsListInfo()
		{ 
			
			//store products in a viewbag,ordered by name
			 ViewBag.Products = vm.Products = spContext.Products.OrderBy(prod => prod.Name).ToList();

			//store techs in a viewbag, ordered by name
			ViewBag.Technicians = vm.Technicians = spContext.Technicians.OrderBy(tech => tech.Name).ToList();

			//store customers in a viewbag order by name														
			ViewBag.Customers = vm.Customers = spContext.Customers.OrderBy(cust => cust.FirstName).ToList();
		}

        [Route("/incidents")]
        public IActionResult List()
		{
			

			//ViewBag.Technicians = spContext.Technicians.ToList();
			
			vm.Incidents = spContext.Incidents.Include(incident => incident.Customer)
								.Include(incident => incident.Product)
								.OrderBy(incident => incident.DateOpened)
								.ToList(); 

			return View("List", vm);
		}





		[HttpGet]
		public IActionResult Add() 
		{
			ViewBag.Action = "Add";
			IncidentsListInfo();


            return View("AddEdit", new Incident());
		}

        [Route("/incidents/edit/id/{id?}")]
        [HttpGet]
		public IActionResult Edit(int id)
		{
			ViewBag.Action = "Edit";

			
			IncidentsListInfo();

			var incident = spContext.Incidents.Find(id);

			return View("AddEdit", incident);
		}

		[HttpPost]
		public IActionResult Save(Incident incident)
		{

			//check if inputs are valid
			if (ModelState.IsValid)
			{

				// if inputs are valid and there is incident choosen, update it
				if (incident.IncidentID > 0)
				{
					spContext.Incidents.Update(incident); // update the selected incident
				}
				//else add a new incident ( incident id == 0 )
				else
				{
					spContext.Incidents.Add(incident);  // makes a new incident 
					
				}

				//save the changes
				spContext.SaveChanges();

				//return to List View of Incident
				return RedirectToAction("List", "Incident");
			}
			else
			{

				IncidentsListInfo();


				

				//  if inputs are not valid, do not go anywhere
				return View("AddEdit", incident);

			}
		}


		[HttpGet]
		public IActionResult Delete(int id)			// get the incident that is choosen to be deleted
		{
			var incident = spContext.Incidents.Find(id);  // find the selected incident from the DB

			return View(incident); 
		}

		[HttpPost]
		public IActionResult Delete(Incident incident)		
		{
			spContext.Incidents.Remove(incident); // deletes the choosen incident

			spContext.SaveChanges();	// save changes

			return RedirectToAction("List","Incident"); // return to the List View of Incident
		}
	}
}
