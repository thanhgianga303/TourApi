using System;
using System.Collections.Generic;

namespace TourApi.Models
{
    public class TouristGroup
    {
        public int TouristGroupId { get; set; }
        public int TourId { get; set; }
        public string GroupName { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScheduleDetails { get; set; }
       // public virtual Tour Tour { get; set; }
        public virtual List<CostDetails> CostDetailsList { get; set; }
        public virtual List<TouristGroupDetailsOfStaff> TouristGroupDetailsOfStaffList { get; set; }
        public virtual List<TouristGroupDetailsOfCustomer> TouristGroupDetailsOfCustomerList { get; set; }
    }
}