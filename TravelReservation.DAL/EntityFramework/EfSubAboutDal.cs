using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.DAL.Abstract;
using TravelReservation.DAL.Repository;
using Traversal.EL.Concrete;

namespace TravelReservation.DAL.EntityFramework
{
    public class EfSubAboutDal : GenericRepository<SubAbout>, ISubAboutDal
    {
    }
}
