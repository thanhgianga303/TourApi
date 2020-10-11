using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class CustomerDTO : People
    {
        public int CustomerId { get; set; }
        public List<TourDetailsOfCustomer> TourDetailsOfCustomerList { get; set; }
    }
}