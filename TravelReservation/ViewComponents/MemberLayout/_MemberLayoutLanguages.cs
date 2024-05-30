using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
