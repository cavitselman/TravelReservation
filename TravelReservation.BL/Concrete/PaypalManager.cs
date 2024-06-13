using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.BL.Abstract;
using TravelReservation.DTOL.DTOs.OrderRequestDTOs;

namespace TravelReservation.BL.Concrete
{
    public class PaypalManager : IPaypalService
    {
        public Task<OrderResponseDTO> CreatePayPalOrder(OrderRequestDTO orderRequest)
        {
            throw new NotImplementedException();
        }
    }
}
