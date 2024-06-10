using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }
               
        public async Task<IActionResult> Index()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            var currentUser = await _userManager.GetUserAsync(User);
            var values = _commentService.TGetListCommentWithDestination().Where(x=>x.AppUserID == currentUser.Id).ToList();
            return View(values);
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return View(values);            
        }
    }
}
