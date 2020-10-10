using System.Collections.Generic;

namespace TourApi.Model
{
    public class Customer : People
    {
        public int CustomerId { get; set; }
        public virtual List<TourDetailsOfCustomer> TourDetailsOfCustomerList { get; set; }
    }
}