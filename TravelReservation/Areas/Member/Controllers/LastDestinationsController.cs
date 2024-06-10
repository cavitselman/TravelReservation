using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public LastDestinationsController(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
