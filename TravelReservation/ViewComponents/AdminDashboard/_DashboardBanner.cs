﻿using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.AdminDashboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();          
        }
    }
}
