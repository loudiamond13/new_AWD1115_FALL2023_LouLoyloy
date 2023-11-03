using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using TripLogs.Models;

namespace TripLogs.Controllers
{
    public class TripController : Controller
    {

        private TripLogsContext tripContext { get; set; }
        
        // constructor
        public TripController(TripLogsContext context) 
        {
            tripContext = context;
        }


        public RedirectToActionResult Index()
        {
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ViewResult Add(string id = "")
        {
            var vm = new TripViewModel();

            if (id.ToLower() == "page2")
            {
                var accommodation = TempData?[nameof(Trip.Accommodation)]?.ToString();

                if (string.IsNullOrEmpty(accommodation))
                {
                    vm.PageNumber = 3;
                    var destination = TempData?.Peek(nameof(Trip.Destination))?.ToString();
                    vm.Trip = new Trip { Destination = destination };
                    return View("Add3", vm);
                }
                else
                {
                    vm.PageNumber = 2;
                    vm.Trip = new Trip { Accommodation = accommodation };
                    TempData.Keep(nameof(Trip.Accommodation));
                    return View("Add2", vm);
                }

            }
            else if (id.ToLower() == "page3")
            {
                vm.PageNumber = 3;
                vm.Trip = new Trip {
                    Destination = TempData?.Peek(nameof(Trip.Destination))?.ToString()
                };
                return View("Add3", vm);
            }
            else 
            {
                vm.PageNumber = 1;
                return View("Add1", vm);
            }

        }

        [HttpPost]
        public IActionResult Add(TripViewModel vm)
        {
            if (vm.PageNumber == 1)
            {
                if (ModelState.IsValid)
                {
                    TempData[nameof(Trip.Destination)] = vm.Trip?.Destination;
                    TempData[nameof(Trip.Accommodation)] = vm.Trip?.Accommodation;
                    TempData[nameof(Trip.StartDate)] = vm.Trip?.StartDate;
                    TempData[nameof(Trip.EndDate)] = vm.Trip?.EndDate;
                    return RedirectToAction("Add", new { id = "Page2" });
                }
                else
                {
                    return View("Add1", vm);
                }
            }
            else if (vm.PageNumber == 2)
            {
                TempData[nameof(Trip.AccommodationPhone)] = vm.Trip?.AccommodationPhone;
                TempData[nameof(Trip.AccommodationEmail)] = vm.Trip?.AccommodationEmail;
                return RedirectToAction("Add", new { id = "Page3" });
            }
            else if (vm.PageNumber == 3)
            {
                vm.Trip.Destination = TempData[nameof(Trip.Destination)]?.ToString();
                vm.Trip.Accommodation = TempData[nameof(Trip.Accommodation)]?.ToString();
                vm.Trip.StartDate = (DateTime?)TempData[nameof(Trip.StartDate)];
                vm.Trip.EndDate = (DateTime?)TempData[nameof(Trip.EndDate)];
                vm.Trip.AccommodationPhone = TempData[nameof(Trip.AccommodationPhone)]?.ToString();
                vm.Trip.AccommodationEmail = TempData[nameof(Trip.AccommodationEmail)]?.ToString();

                tripContext.Trips.Add(vm.Trip);
                tripContext.SaveChanges();
                TempData["message"] = $"Trip to {vm.Trip.Destination} added.";
                return RedirectToAction("Index", "Home");
            }
            else 
            {
            return RedirectToAction("Index", "Home");
            }
        }

        public RedirectToActionResult Cancel()
        { 
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        
        }
    }

  
}
