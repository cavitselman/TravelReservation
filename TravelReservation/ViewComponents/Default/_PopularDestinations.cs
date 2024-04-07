using Microsoft.AspNetCore.Mvc;
using TravelReservation.BL.Concrete;
using TravelReservation.DAL.EntityFramework;

namespace TravelReservation.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
