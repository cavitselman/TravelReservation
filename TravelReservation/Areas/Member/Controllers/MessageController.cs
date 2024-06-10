using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TravelReservation.EL.Concrete;
using TravelReservation.Models;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var pp = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = pp.Name + " " + pp.Surname;
            ViewBag.userImage = pp.ImageUrl; //Layoutta profil resmini getirmek için
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(MailRequest mailRequest)
        //{
        //    MimeMessage mimeMessage = new MimeMessage();

        //    MailboxAddress mailboxAddress = new MailboxAddress("Admin", "deneme@gmail.com");

        //    mimeMessage.From.Add(mailboxAddress);

        //    MailboxAddress mailboxAdressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
        //    mimeMessage.To.Add(mailboxAdressTo);

        //    var bodyBuilder = new BodyBuilder();
        //    bodyBuilder.TextBody = mailRequest.Body;
        //    mimeMessage.Body = bodyBuilder.ToMessageBody();

        //    mimeMessage.Subject = mailRequest.Subject;

        //    SmtpClient client = new SmtpClient();
        //    client.Connect("smtp.gmail.com", 587, false);
        //    client.Authenticate("deneme@gmail.com", "deneme123");
        //    client.Send(mimeMessage);
        //    client.Disconnect(true);
        //    return View();
        //}
    }
}
