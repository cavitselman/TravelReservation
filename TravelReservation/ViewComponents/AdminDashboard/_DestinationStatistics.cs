using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.AdminDashboard
{
    public class _DestinationStatistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
