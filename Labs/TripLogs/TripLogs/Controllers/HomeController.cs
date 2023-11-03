using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripLogs.Models;

namespace TripLogs.Controllers
{
    public class HomeController : Controller
    {
     
        private TripLogsContext tripContext { get; set; }

        public HomeController(TripLogsContext context)
        {
            tripContext = context;
        }

        public IActionResult Index()
        {
            var trips = tripContext.Trips.OrderBy( t => t.StartDate ).ToList();
            return View(trips);
        }

       
    }
}