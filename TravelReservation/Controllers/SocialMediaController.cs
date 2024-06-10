using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Controllers
{
    public class SocialMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
