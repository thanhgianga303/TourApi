using TourApi.Models;

namespace TourApi.DTOs
{
    public class TouristGroupDetailsOfStaffDTO
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int TouristGroupId { get; set; }
        public TouristGroup TouristGroup { get; set; }
        public Staff Staff { get; set; }
    }
}