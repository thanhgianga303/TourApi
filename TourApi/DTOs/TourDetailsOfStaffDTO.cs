using TourApi.Models;

namespace TourApi.DTOs
{
    public class TourDetailsOfStaffDTO
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public Staff Staff { get; set; }
    }
}