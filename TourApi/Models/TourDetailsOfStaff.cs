namespace TourApi.Model
{
    public class TourDetailsOfStaff
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int TourId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual Staff Staff { get; set; }
    }
}