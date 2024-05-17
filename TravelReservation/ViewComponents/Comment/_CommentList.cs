using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.Concrete;
using TravelReservation.DAL.EntityFramework;

namespace TravelReservation.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        Context context = new Context();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.DestinationID == id).Count();
            var values= commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}
