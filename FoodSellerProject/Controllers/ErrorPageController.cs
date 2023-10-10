using Microsoft.AspNetCore.Mvc;

namespace FoodSellerProject.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404()
        {
            Response.StatusCode = 404;
            
            return View();
        }
        public IActionResult Page403()
        {
            Response.StatusCode = 403;
            
            return View();
        }
    }
}
