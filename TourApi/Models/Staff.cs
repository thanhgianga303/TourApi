using System.Collections.Generic;

namespace TourApi.Models
{
    public class Staff : People
    {
        public int StaffId { get; set; }
        public virtual List<JobDetails> JobDetailsList { get; set; }
        public virtual List<TouristGroupDetailsOfStaff> TouristGroupDetailsOfStaffList { get; set; }
    }
}