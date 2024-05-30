using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberLayout
{
    public class _MemberLayoutHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
