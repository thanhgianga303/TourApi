using System.Collections.Generic;

namespace TourApi.Models
{
    public class Tour
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Description { get; set; }
        public int TypesOfTourismId { get; set; }
        public virtual TypesOfTourism TypesOfTourism { get; set; }
        public virtual List<TourPrice> TourPriceList { get; set; }
        public virtual List<TourDetails> TourDetailsList { get; set; }
        public virtual List<TouristGroup> TouristGroup { get; set; }
    }
}