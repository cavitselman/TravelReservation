using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;

namespace TravelReservation.ViewComponents.MemberDashboard
{
    public class _LastDestinations:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
