using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.Areas.Admin.Models;
using TravelReservation.BL.Abstract;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            List<Announcement> announcements = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            foreach(var item in announcements)
            {
                AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
                announcementListViewModel.ID = item.AnnouncementID;
                announcementListViewModel.Title = item.Title;
                announcementListViewModel.Content = item.Content;

                model.Add(announcementListViewModel);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(string x)
        {
            return View();
        }
    }
}
