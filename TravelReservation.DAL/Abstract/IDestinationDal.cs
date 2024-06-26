﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.EL.Concrete;

namespace TravelReservation.DAL.Abstract
{
    public interface IDestinationDal:IGenericDal<Destination>
    {
        public Destination GetDestinationWithGuide(int id);
        public List<Destination> GetLast4Destinations();
    }
}
