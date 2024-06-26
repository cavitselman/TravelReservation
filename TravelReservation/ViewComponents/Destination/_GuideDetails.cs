﻿using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Abstract;

namespace TravelReservation.ViewComponents.Destination
{
    public class _GuideDetails:ViewComponent
    {
        private readonly IGuideService _guideService;
        public _GuideDetails(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_guideService.TGetByID(1);
            return View(values);
        }
    }
}
