using System;
using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class TouristGroupDTO
    {
        public int TouristGroupId { get; set; }
        public string GroupName { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ScheduleDetails { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public List<CostDetails> CostDetailsList { get; set; }
        public List<TouristGroupDetailsOfStaff> TouristGroupDetailsOfStaffList { get; set; }
        public List<TouristGroupDetailsOfCustomer> TouristGroupDetailsOfCustomerList { get; set; }
    }
}