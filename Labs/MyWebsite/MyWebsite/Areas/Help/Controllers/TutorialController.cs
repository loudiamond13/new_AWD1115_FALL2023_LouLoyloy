using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {

        public IActionResult Index(string id)
        {
            if (id == "Page2")
            {return View("Page2");
		}

            else if (id == "Page3")
            { return View("Page3"); }

			else {return View("Page1");}
	     }
    }
}
