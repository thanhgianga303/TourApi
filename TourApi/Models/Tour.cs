using System.Collections.Generic;

namespace TourApi.Models
{
    public class Tour
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string TourCharacteristics { get; set; }
        public int TypeId { get; set; }
        public int TourPriceId { get; set; }
        public virtual TypesOfTourism TypesOfTourism { get; set; }
        public virtual TourPrice TourPrice { get; set; }
        public virtual List<TourDetailsOfStaff> TourDetailsOfStaffList { get; set; }
        public virtual List<TourDetailsOfCustomer> TourDetailsOfCustomerList { get; set; }
        public virtual List<TourDetails> TourDetailsList { get; set; }
        public virtual List<TouristGroup> TouristGroup { get; set; }
    }
}