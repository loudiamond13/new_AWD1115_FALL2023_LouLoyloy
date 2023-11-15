using Microsoft.AspNetCore.Mvc;
using SportsPro.DataLayer;
using SportsPro.Models.Validations;

namespace SportsPro.Controllers
{
    public class ValidationController : Controller
    {
        private SportsProContext spContext;

        public ValidationController(SportsProContext context)
        {
            spContext = context;
        }

        public JsonResult ValidateEmail (string email, int customerID)
        {
            if (customerID == 0)
            {
                string message = Validate.CheckIfEmailExists(spContext, email);
                if (!string.IsNullOrEmpty(message))
                { 
                    return Json(message);
                }
            }

            TempData["okEmail"] = true;
            return Json(true);
        }
    }
}
