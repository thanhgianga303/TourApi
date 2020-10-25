namespace TourApi.Models
{
    public class TourDetailsOfStaff
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int TouristGroupId { get; set; }
        public virtual TouristGroup TouristGroup { get; set; }
        public virtual Staff Staff { get; set; }
    }
}