using System.Collections.Generic;
using TourApi.Models;

namespace TourApi.DTOs
{
    public class JobDTO
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public List<JobDetails> JobDetailsList { get; set; }
    }
}