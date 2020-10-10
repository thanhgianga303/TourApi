using System.Collections.Generic;

namespace TourApi.Model
{
    public class Cost
    {
        public int CostId { get; set; }
        public string CostName { get; set; }
        public int Price { get; set; }
        public virtual List<CostDetails> CostDetailsList { get; set; }
    }
}