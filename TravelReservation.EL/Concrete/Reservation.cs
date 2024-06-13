using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservation.EL.Concrete
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int DestinationID { get; set; }
        public int DayNight { get; set; }
        public decimal TotalPrice { get; set; }
        public int NightPrice { get; set; }
        public Destination Destination { get; set; }
    }
}
