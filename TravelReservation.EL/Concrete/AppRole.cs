using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservation.EL.Concrete
{
    public class AppRole : IdentityRole<int>
    {
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}
