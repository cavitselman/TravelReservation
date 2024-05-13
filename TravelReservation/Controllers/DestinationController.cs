using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values = destinationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
