using HealthFirst.Todo;

namespace HealthFirst.App.Models.Todo
{
    public sealed class TodoItemModel : ITodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        private Status _status = Status.NotStarted;
        public Status Status
        {
            get => _status; set 
            {
                _status = value;
                if (value == Status.Completed)
                    FinishedTime = DateTime.Now;
                else
                    FinishedTime = null;
            }
        }

        public Priority Priority { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime? FinishedTime { get; set; }
        public DateTime DeadlineTime { get; set; } = DateTime.Now;

        public TodoItemModel()
        {

        }

        public TodoItemModel(ITodoItem todoItem)
        {
            Title = todoItem.Title;
            Description = todoItem.Description;
            CreatedTime = todoItem.CreatedTime;
            DeadlineTime = todoItem.DeadlineTime;
            Status = todoItem.Status;
            Priority = todoItem.Priority;
        }

        public TodoItemModel(string title, string description, DateTime createDate, DateTime deadlineTime, Status status = Status.NotStarted, Priority priority = Priority.Low)
        {
            Title = title;
            Description = description;
            CreatedTime = createDate;
            DeadlineTime = deadlineTime;
            Status = status;
            Priority = priority;
        }
    }
}
