using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Controllers
{
    public class DestinationDetailsController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationDetailsController(UserManager<AppUser> userManager, IDestinationService destinationService)
        {
            _userManager = userManager;
            _destinationService = destinationService;
        }

        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = _destinationService.TGetDestinationWithGuide(id);
            return View(values);
        }
    }
}
