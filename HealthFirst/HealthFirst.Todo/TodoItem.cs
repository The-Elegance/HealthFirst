namespace HealthFirst.Todo
{
    public class TodoItem : ITodoItem
    {
        public string Title { get; }
        public string Description { get; }
        public Status Status { get; private set; }
        public Priority Priority { get; }
        public DateTime CreatedTime { get; }
        public DateTime? FinishedTime { get; private set; }
        public DateTime DeadlineTime  { get; }

        public TodoItem(string title, string description, DateTime createDate, DateTime deadlineTime, Status status = Status.NotStarted, Priority priority = Priority.Low, DateTime? finishedTime = null)
        {
            if (createDate > deadlineTime)
                throw new ArgumentException("Deadline cannot be earlier than creation date");

            Title = title;
            Description = description;
            CreatedTime = createDate;
            DeadlineTime = deadlineTime;
            Status = status;
            Priority = priority;
            FinishedTime = finishedTime;
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
