using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourDetailsOfCustomerDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TouristGroupId { get; set; }
        public TouristGroup TouristGroup { get; set; }
        public Customer Customer { get; set; }
    }
}