using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.BL.Abstract;
using TravelReservation.DAL.Abstract;
using TravelReservation.EL.Concrete;

namespace TravelReservation.BL.Concrete
{
    public class GuideManager : IGuideService
    {
        IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide t)
        {
            throw new NotImplementedException();
        }

        public Guide TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
