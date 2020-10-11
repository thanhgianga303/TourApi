using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourDetailsDTO
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int LocationId { get; set; }
        public Tour Tour { get; set; }
        public Location Location { get; set; }
    }
}