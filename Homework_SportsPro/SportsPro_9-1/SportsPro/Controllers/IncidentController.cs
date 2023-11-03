using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SportsPro.Models;
using SportsPro.Models.ViewModels;
using SportsPro.Repositories.Interfaces;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace SportsPro.Controllers
{
	public class IncidentController : Controller
	{
		private SportsProContext spContext { get; set; }
		private readonly IUnitOfWork unitOfWork;

		public IncidentController(SportsProContext context, IUnitOfWork ctx)
		{
			unitOfWork = ctx;
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
		public ViewResult List(String name)
		{


			//ViewBag.Technicians = spContext.Technicians.ToList();

			IncidentViewModel incidentViewModel = new IncidentViewModel();

			//incidentViewModel.Incidents = unitOfWork.Incidents.GetAll().ToList();

			incidentViewModel.Incidents = spContext.Incidents.Include(incident => incident.Customer)
								.Include(incident => incident.Product)
								.OrderBy(incident => incident.DateOpened)
								.ToList();


			return View("List", incidentViewModel);
		}


		// update incident list 
		//technician select list
        [Route("update-incident/select-tech/")]
        public ViewResult TechniciansSelectList()
        {
			var incidents = unitOfWork.Incidents.GetAll();

			IncidentViewModel incidentViewModel = new IncidentViewModel()
			{
				Technicians = unitOfWork.Technicians.GetAll().ToList(),
				Incidents = unitOfWork.Incidents.GetAll().ToList(),
			};

			ViewBag.Technicians = unitOfWork.Technicians.GetAll();

			// returns the technicians
            return View("TechniciansSelectList", incidentViewModel);
        }







		[Route("/update-incident/list/id/{id?}")]

		[HttpGet]
        public ViewResult UpdateIncidentsList(Technician technician)
        {
            
			
            vm.Incidents = unitOfWork.Incidents.GetIncidentsOfSelectedTech(technician.TechnicianID).ToList();
            vm.Technician = unitOfWork.Technicians.GetByID(technician.TechnicianID);

            return View("UpdateIncidentsList", vm);
        }


        [Route("update-incident/update/id/{id?}")]
        [HttpGet]
        public ViewResult UpdateIncident(int id)
        {
			ViewBag.Action = "UpdateIncident";
            var incident = unitOfWork.Incidents.GetIncidentForUpdate(id).FirstOrDefault();
        
            return View("UpdateIncident", incident);
        }


		[HttpPost]
		public IActionResult Save(Incident incident)
		{
			if (ModelState.IsValid)
			{
				if (incident.IncidentID != 0)
				{
					unitOfWork.Update(incident);
				}
				unitOfWork.Complete();
				return RedirectToAction("TechniciansSelectList", "Incident");
			}

			else
			{
				IncidentViewModel incidentViewModel = new IncidentViewModel()
				{
					Technicians = unitOfWork.Technicians.GetAll().ToList()
					
				};

				return View("TechniciansSelectList");
			}
		}
	
		



		[Route("/incident/add/")]

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

			var incident = unitOfWork.Incidents.GetByID(id);// spContext.Incidents.Find(id);


			return View("AddEdit", incident);
		}

		[HttpPost]
		public IActionResult AddEdit(Incident incident)
		{
			
			//check if inputs are valid
			if (ModelState.IsValid)
			{
				
				// if inputs are valid and there is incident choosen, update it
				if (incident.IncidentID > 0)
				{
					

                    unitOfWork.Update(incident);
					//spContext.Incidents.Update(incident); // update the selected incident
				}
				//else add a new incident ( incident id == 0 )
				else
				{
					unitOfWork.Incidents.Add(incident);

				}

				//save the changes
				spContext.SaveChanges();

				
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
		public IActionResult Delete(int id)         // get the incident that is choosen to be deleted
		{
			var incident = spContext.Incidents.Find(id);  // find the selected incident from the DB

			return View(incident);
		}

		[HttpPost]
		public IActionResult Delete(Incident incident)
		{
			spContext.Incidents.Remove(incident); // deletes the choosen incident

			spContext.SaveChanges();    // save changes

			return RedirectToAction("List", "Incident"); // return to the List View of Incident
		}



    }
}
