using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TravelReservation.BL.Abstract;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IDestinationService destinationService, IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyOldReservation()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByWaitAprroval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public async Task<IActionResult> NewReservation()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                p.AppUserId = currentUser.Id;
                p.Status = "Onay Bekliyor";
                decimal totalPrice = CalculatePrice(p.NightPrice, p.DayNight, p.PersonCount);
                p.TotalPrice = totalPrice;
                _reservationService.TAdd(p);
                return RedirectToAction("ReservationPayment", "Payment", new { area = "Member", reservationId = p.ReservationID });
            }
            return Redirect("/Member/Reservation/MyApprovalReservation");
        }
        private decimal CalculatePrice(int basePricePerNight, int numberOfNights, int numberOfPeople)
        {
            // Her gece için belirlenen fiyatı, gece sayısı ve kişi sayısı ile çarp
            decimal totalPrice = basePricePerNight * numberOfNights * numberOfPeople;

            return totalPrice;
        }
    }
}
