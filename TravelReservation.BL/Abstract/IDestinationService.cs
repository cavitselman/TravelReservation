﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.EL.Concrete;

namespace TravelReservation.BL.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
