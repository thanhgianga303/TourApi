using System;
using System.Collections.Generic;

namespace TourApi.Models
{
    public class TourPrice
    {
        public int TourPriceId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Tour> TourList { get; set; }
    }
}