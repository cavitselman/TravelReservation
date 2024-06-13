using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class PaymentController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly UserManager<AppUser> _userManager;

        public PaymentController(IReservationService reservationService, UserManager<AppUser> userManager)
        {
            _reservationService = reservationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> ReservationPayment()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(string cardNumber, string expiryDate, string cvc)
        {
            // Ödeme işlemini simüle et
            bool paymentSuccess = SimulatePaymentProcess(cardNumber, expiryDate, cvc);

            if (paymentSuccess)
            {
                ViewBag.SuccessMessage = "Ödeme başarıyla tamamlandı!";
            }
            else
            {
                ViewBag.ErrorMessage = "Ödeme işlemi başarısız oldu. Lütfen bilgilerinizi kontrol edin.";
            }

            return View("ReservationPayment");
        }

        private bool SimulatePaymentProcess(string cardNumber, string expiryDate, string cvc)
        {
            // Gerçek bir ödeme işlemi burada yapılır. Bu örnekte işlemi simüle ediyoruz.
            // Gerçek bir ödeme sağlayıcısı ile entegre etmek için API çağrıları yapılması gerekir.
            // Örnek olarak sadece true dönüyoruz.
            return true;
        }
    }
}
