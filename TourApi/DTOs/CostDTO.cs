using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class CostDTO
    {
        public int CostId { get; set; }
        public string CostName { get; set; }
        public int Price { get; set; }
        public List<CostDetails> CostDetailsList { get; set; }
    }
}