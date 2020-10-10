namespace TourApi.Model
{
    public class TourDetails
    {
        public int Id { get; set; }
        public int TourId { get; set; }
        public int LocationId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual Location Location { get; set; }
    }
}