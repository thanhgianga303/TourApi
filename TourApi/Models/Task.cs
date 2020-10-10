using System.Collections.Generic;

namespace TourApi.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public virtual List<TaskDetails> TaskDetailsList { get; set; }
    }
}