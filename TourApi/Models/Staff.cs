using System.Collections.Generic;

namespace TourApi.Model
{
    public class Staff : People
    {
        public int StaffId { get; set; }
        public virtual List<TaskDetails> TaskDetailsList { get; set; }
        public virtual List<TourDetailsOfStaff> TourDetailsOfStaffList { get; set; }
    }
}