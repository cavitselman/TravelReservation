﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;
using TravelReservation.EL.Concrete;

namespace TravelReservation.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        //[HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = destinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        //[HttpPost]
        //public ActionResult DestinationDetails(Destination p)
        //{
        //    return View();
        //}
    }
}
