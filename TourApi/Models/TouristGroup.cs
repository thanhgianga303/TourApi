using System;
using System.Collections.Generic;

namespace TourApi.Model
{
    public class TouristGroup
    {
        public int TouristGroupId { get; set; }
        public string GroupName { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TourId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual List<CostDetails> CostDetailsList { get; set; }
    }
}