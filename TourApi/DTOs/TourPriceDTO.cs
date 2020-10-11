using System;
using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourPriceDTO
    {
        public int TourPriceId { get; set; }
        public int Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Tour> TourList { get; set; }
    }
}
