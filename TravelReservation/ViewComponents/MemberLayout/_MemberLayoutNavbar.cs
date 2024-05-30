using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
