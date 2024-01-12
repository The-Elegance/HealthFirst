using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Todo
{
    public class TodoItem : ITodoItem<TodoItem>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedTime { get; }
        public DateTime? FinishedTime { get; set; }

        private DateTime _deadline;
        public DateTime DeadlineTime 
        {
            get => _deadline; set
            {
                if (CreatedTime > value)
                    throw new ArgumentException("Deadline cannot be earlier than creation date");
                _deadline = value;
            }
        }

        public TodoItem(string title, string description, DateTime createDate, DateTime deadlineTime, Status status = Status.NotStarted, Priority priority = Priority.Low) 
        {
            Title = title;
            Description = description;  
            CreatedTime = createDate;   
            DeadlineTime = deadlineTime;
            Status = status;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"Title:{Title} Description:{Description} CreatedTime:{CreatedTime} DeadlineTime:{DeadlineTime} Status:{Status} Priority:{Priority}";
        }

        public void ChangeStatus(Status status, DateTime? finishedTime)
        {
            Status = status;
            if (status == Status.Completed)
            {
                FinishedTime = finishedTime;
            }
            FinishedTime = null;
        }
    }
}
