using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class TechnicianController : Controller
    {

        private SportsProContext spContext { get; set; }

        // constructor
        public TechnicianController(SportsProContext context)
        { 
            spContext = context;
        }

        [Route("/technicians")]
        public IActionResult List()
        {
            //List<Product>
            //list of techs
            var technicians = spContext.Technicians.OrderBy(tech => tech.Name)
                                                        .ToList();
            return View(technicians);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            //return the AddEdit View With a new/empty techs context
            return View("AddEdit", new Technician());
        }


        [Route("/technicians/edit/id/{id?}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";

            //find the passed in tech id
            var technician = spContext.Technicians.Find(id);

            //  
            return View("AddEdit", technician);
        }

        [HttpPost]
        public IActionResult Save(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianID == 0)
                {
                    spContext.Technicians.Add(technician);
                }
                else
                {
                    spContext.Technicians.Update(technician);
                }

                spContext.SaveChanges();

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
            var technician = spContext.Technicians.Find(id);
            return View(technician);
        }

        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            spContext.Technicians.Remove(technician);
            spContext.SaveChanges();
            return RedirectToAction("List", "Technician");
        }

    }
}
