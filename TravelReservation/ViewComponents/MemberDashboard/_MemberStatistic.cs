using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberDashboard
{
    public class _MemberStatistic:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
