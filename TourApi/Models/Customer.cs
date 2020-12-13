using System.Collections.Generic;

namespace TourApi.Models
{
    public class Customer : People
    {
        public int CustomerId { get; set; }
        //public virtual List<TouristGroupDetailsOfCustomer> TouristGroupDetailsOfCustomerList { get; set; }
    }
}