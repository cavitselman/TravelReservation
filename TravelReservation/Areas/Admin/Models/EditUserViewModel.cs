using TravelReservation.EL.Concrete;

namespace TravelReservation.Areas.Admin.Models
{
    public class EditUserViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
