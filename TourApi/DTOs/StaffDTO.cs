using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class StaffDTO : People
    {
        public int StaffId { get; set; }
        public List<JobDetails> JobDetailsList { get; set; }
        public List<TourDetailsOfStaff> TourDetailsOfStaffList { get; set; }
    }
}