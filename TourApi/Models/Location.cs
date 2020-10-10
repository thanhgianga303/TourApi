using System.Collections.Generic;

namespace TourApi.Model
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public virtual List<TourDetails> TourDetailsList { get; set; }
        public virtual List<Hotel> HotelList { get; set; }
    }
}