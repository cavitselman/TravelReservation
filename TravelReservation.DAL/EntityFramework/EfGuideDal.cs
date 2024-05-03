﻿using System;
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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }
    }
}
