using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.MemberLayout
{
    public class _MemberLayoutHeaderContent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
