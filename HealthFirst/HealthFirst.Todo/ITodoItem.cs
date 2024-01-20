

namespace HealthFirst.Todo
{
    public interface ITodoItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedTime { get; }
        public DateTime? FinishedTime { get; set; }
        public DateTime DeadlineTime { get; set; }
    }
}
