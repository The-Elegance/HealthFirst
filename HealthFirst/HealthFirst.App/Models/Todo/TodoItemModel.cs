using HealthFirst.Todo;

namespace HealthFirst.App.Models.Todo
{
    public sealed class TodoItemModel : ITodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; } = Status.NotStarted;
        public Priority Priority { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? FinishedTime { get; set; }
        public DateTime DeadlineTime { get; set; }

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
