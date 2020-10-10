namespace TourApi.Model
{
    public class CostDetails
    {
        public int Id { get; set; }
        public int TouristGroupId { get; set; }
        public int CostId { get; set; }
        public string Note { get; set; }
        public virtual TouristGroup TouristGroup { get; set; }
        public virtual Cost Cost { get; set; }
    }
}