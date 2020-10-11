using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourDetailsOfCustomerDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TourId { get; set; }
        public Customer Customer { get; set; }
        public Tour Tour { get; set; }
    }
}