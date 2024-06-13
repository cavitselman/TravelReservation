using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelReservation.DTOL.DTOs.OrderRequestDTOs;

namespace TravelReservation.BL.Abstract
{
    public interface IPaypalService
    {
        Task<OrderResponseDTO> CreatePayPalOrder(OrderRequestDTO orderRequest);
    }
}
