using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class CostDTO
    {
        public int CostId { get; set; }
        public string CostName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<CostDetails> CostDetailsList { get; set; }
    }
}