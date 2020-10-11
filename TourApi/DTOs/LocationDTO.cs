using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class LocationDTO
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public List<TourDetails> TourDetailsList { get; set; }
        public List<Hotel> HotelList { get; set; }
    }
}