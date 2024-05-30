using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Controllers
{
    public class InformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
