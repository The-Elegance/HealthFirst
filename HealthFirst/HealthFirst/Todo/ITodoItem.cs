

namespace HealthFirst.Core.Todo
{
    public interface ITodoItem<T> where T : ITodoItem<T>
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
