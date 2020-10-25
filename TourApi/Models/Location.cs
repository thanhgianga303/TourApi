using System.Collections.Generic;

namespace TourApi.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Country { get; set; }
        public virtual List<TourDetails> TourDetailsList { get; set; }
    }
}