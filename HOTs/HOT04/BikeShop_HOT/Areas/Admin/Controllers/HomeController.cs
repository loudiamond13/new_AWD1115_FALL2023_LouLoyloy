using Microsoft.AspNetCore.Mvc;

namespace BikeShop_HOT.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [Route("/admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
