namespace TourApi.Models
{
    public class TouristGroupDetailsOfCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TouristGroupId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual TouristGroup TouristGroup { get; set; }
    }
}