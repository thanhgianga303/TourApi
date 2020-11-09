using TourApi.Models;

namespace TourApi.DTOs
{
    public class CostDetailsDTO
    {
        public int Id { get; set; }
        public int TouristGroupId { get; set; }
        public int CostId { get; set; }
        public decimal Price { get; set; }
        public string CostDetailsName { get; set; }
        public TouristGroup TouristGroup { get; set; }
        public Cost Cost { get; set; }
    }
}