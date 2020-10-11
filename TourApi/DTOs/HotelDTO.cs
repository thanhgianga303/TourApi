using TourApi.Models;
namespace TourApi.DTOs
{
    public class HotelDTO
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}