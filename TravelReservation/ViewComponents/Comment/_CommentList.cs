using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
