namespace TourApi.Models
{
    public class TourDetailsOfCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TouristGroupId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TouristGroup TouristGroup { get; set; }
    }
}