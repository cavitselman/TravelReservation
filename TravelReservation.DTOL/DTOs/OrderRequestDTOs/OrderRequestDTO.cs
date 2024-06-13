using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelReservation.DTOL.DTOs.OrderRequestDTOs
{
    public class OrderRequestDTO
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    public class OrderResponseDTO
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        // Diğer özellikler buraya eklenebilir
    }
}
