using System.Collections.Generic;

namespace TourApi.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public virtual List<JobDetails> JobDetailsList { get; set; }
    }
}