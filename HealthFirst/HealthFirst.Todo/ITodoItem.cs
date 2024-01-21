

namespace HealthFirst.Todo
{
    public interface ITodoItem
    {
        string Title { get; }
        string Description { get; }
        Status Status { get; }
        Priority Priority { get; }
        DateTime CreatedTime { get; }
        DateTime? FinishedTime { get; }
        DateTime DeadlineTime { get; }
    }
}
