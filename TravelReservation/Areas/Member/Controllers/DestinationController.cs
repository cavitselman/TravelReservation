using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
