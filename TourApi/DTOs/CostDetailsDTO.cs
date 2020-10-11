using TourApi.Models;

namespace TourApi.DTOs
{
    public class CostDetailsDTO
    {
        public int Id { get; set; }
        public int TouristGroupId { get; set; }
        public int CostId { get; set; }
        public string Note { get; set; }
        public TouristGroup TouristGroup { get; set; }
        public Cost Cost { get; set; }
    }
}