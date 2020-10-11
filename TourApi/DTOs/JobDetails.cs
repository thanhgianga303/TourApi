using TourApi.Models;

namespace TourApi.DTOs
{
    public class JobDetailsDTO
    {
        public int Id { get; set; }
        public int DutyId { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        public Job Job { get; set; }
    }
}