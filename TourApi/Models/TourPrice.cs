using System;
using System.Collections.Generic;

namespace TourApi.Models
{
    public class TourPrice
    {
        public int TourPriceId { get; set; }
        public int TourId { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Tour Tour { get; set; }
    }
}