using System;
using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourPriceDTO
    {
        public int TourPriceId { get; set; }
        public int TourId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Tour Tour { get; set; }
    }
}
