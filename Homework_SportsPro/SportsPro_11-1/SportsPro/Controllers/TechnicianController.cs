using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;
using SportsPro.Repositories.Interfaces;

namespace SportsPro.Controllers
{
    public class TechnicianController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private ITechnicianRepository technicianContextRepository;

        // constructor
        public TechnicianController(ITechnicianRepository context, IUnitOfWork ctx)
        { 
            technicianContextRepository = context;
            unitOfWork = ctx;
        }

        [Route("/technicians")]
        public IActionResult List()
        {
            //List<Product>
            //list of techs
            ViewBag.Technicians = technicianContextRepository.GetAll().OrderBy(tech => tech.Name)
                                                        .ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            //return the AddEdit View With a new/empty techs context
            return View("AddEdit", new Technician());
        }


        
        [HttpGet]
        [Route("/technicians/edit/id/{id?}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            //find the passed in tech id
            var technician = technicianContextRepository.GetByID(id);

            //  
            return View("AddEdit", technician);
        }

        [HttpPost]
        public IActionResult AddEdit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianID == 0)
                {
                    unitOfWork.Technicians.Add(technician);
                }
                else
                {
                    unitOfWork.Update(technician);
                }

                unitOfWork.Complete();

                return RedirectToAction("List", "Technician");
            }
            else
            {
                if (technician.TechnicianID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "Edit";
                }

                return View("List",technician);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var technician = technicianContextRepository.GetByID(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            unitOfWork.Technicians.Delete(technician);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            return RedirectToAction("List", "Technician");
        }

    }
}
