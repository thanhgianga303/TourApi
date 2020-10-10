namespace TourApi.Model
{
    public class TaskDetails
    {
        public int Id { get; set; }
        public int DutyId { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Task Task { get; set; }
    }
}