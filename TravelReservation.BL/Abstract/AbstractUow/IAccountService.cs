using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.EL.Concrete;

namespace TravelReservation.BL.Abstract.AbstractUow
{
    public interface IAccountService : IGenericUowService<Account>
    {
    }
}
