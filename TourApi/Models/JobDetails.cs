namespace TourApi.Models
{
    public class JobDetails
    {
        public int Id { get; set; }
        public int DutyId { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Job Job { get; set; }
    }
}