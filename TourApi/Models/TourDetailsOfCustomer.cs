namespace TourApi.Models
{
    public class TourDetailsOfCustomer
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TourId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Tour Tour { get; set; }
    }
}