using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.DAL.Abstract;
using TravelReservation.DAL.Concrete;
using TravelReservation.DAL.Repository;
using TravelReservation.EL.Concrete;

namespace TravelReservation.DAL.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using(var c=new Context())
            {
                return c.Comments.Include(x=>x.Destination).ToList();
            }
        }
    }
}
