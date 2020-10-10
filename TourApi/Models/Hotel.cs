namespace TourApi.Model
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}