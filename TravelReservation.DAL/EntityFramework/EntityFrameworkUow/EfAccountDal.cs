using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.DAL.Abstract.AbstractUow;
using TravelReservation.DAL.Concrete;
using TravelReservation.DAL.Repository;
using TravelReservation.EL.Concrete;

namespace TravelReservation.DAL.EntityFramework.EntityFrameworkUow
{
    public class EfAccountDal : GenericUowRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {

        }
    }
}
