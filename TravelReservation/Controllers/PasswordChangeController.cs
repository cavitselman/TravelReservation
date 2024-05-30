using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Controllers
{
    public class PasswordChangeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
