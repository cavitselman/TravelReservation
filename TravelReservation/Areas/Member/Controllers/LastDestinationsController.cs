using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinationsController : Controller
    {
        private readonly IDestinationService _destinationService;

        public LastDestinationsController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
