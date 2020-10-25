using System.Collections.Generic;

namespace TourApi.Models
{
    public class Cost
    {
        public int CostId { get; set; }
        public string CostName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public virtual List<CostDetails> CostDetailsList { get; set; }
    }
}