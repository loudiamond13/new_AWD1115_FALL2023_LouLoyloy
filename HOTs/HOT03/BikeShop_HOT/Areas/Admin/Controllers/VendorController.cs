using Microsoft.AspNetCore.Mvc;

namespace BikeShop_HOT.Areas.Admin.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
