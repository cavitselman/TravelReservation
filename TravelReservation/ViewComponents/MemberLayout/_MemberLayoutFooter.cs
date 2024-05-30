using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
