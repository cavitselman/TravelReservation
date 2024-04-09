using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
