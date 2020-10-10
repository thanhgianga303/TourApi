using System.Collections.Generic;

namespace TourApi.Model
{
    public class Staff : People
    {
        public int StaffId { get; set; }
        public virtual List<JobDetails> JobDetailsList { get; set; }
        public virtual List<TourDetailsOfStaff> TourDetailsOfStaffList { get; set; }
    }
}