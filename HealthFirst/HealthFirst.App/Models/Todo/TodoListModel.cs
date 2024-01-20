using HealthFirst.App.Services;
using HealthFirst.Todo;
using System.Collections.ObjectModel;

namespace HealthFirst.App.Models.Todo
{
    public sealed class TodoListModel
    {
        public IEnumerable<TodoItemModel> GetAllTodoItems { get => NotStarted.Concat(InProgress.Concat(Completed)); }
        public IList<TodoItemModel> NotStarted { get; } = new ObservableCollection<TodoItemModel>();
        public IList<TodoItemModel> InProgress { get; } = new ObservableCollection<TodoItemModel>();
        public IList<TodoItemModel> Completed { get; } = new ObservableCollection<TodoItemModel>();

        public void ToNotStarted(TodoItemModel item)
        {
            if (item.Status == Status.InProgress)
                InProgress.Remove(item);
            else Completed.Remove(item);

            item.Status = Status.NotStarted;
            NotStarted.Add(item);
        }

        public void ToInProgress(TodoItemModel item)
        {
            if (item.Status == Status.NotStarted)
                NotStarted.Remove(item);
            else Completed.Remove(item);

            item.Status = Status.InProgress;
            InProgress.Add(item);
        }

        public void ToCompleted(TodoItemModel item)
        {
            if (item.Status == Status.NotStarted)
                NotStarted.Remove(item);
            else InProgress.Remove(item);

            item.Status = Status.Completed;
            Completed.Add(item);
        }

        public void Delete(TodoItemModel item)
        {
            switch (item.Status)
            {
                case Status.NotStarted:
                    NotStarted.Remove(item);
                    break;
                case Status.InProgress:
                    InProgress.Remove(item);
                    break;
                case Status.Completed:
                    Completed.Remove(item);
                    break;
                default:
                    throw new ArgumentException("Unknowed status");
            }
        }


        public void AddItem(TodoItemModel todoItemModel) 
        {
            switch (todoItemModel.Status)
            {
                case Status.NotStarted:
                    NotStarted.Add(todoItemModel);
                    break;
                case Status.InProgress:
                    InProgress.Add(todoItemModel);
                    break;
                case Status.Completed:
                    Completed.Add(todoItemModel);
                    break;
                default:
                    throw new ArgumentException("Unknowed status");
            }
        }

        public void SaveTodo() 
        {
            var s = new TodoService();
            s.SaveTodoModel(this);
        }

        public TodoListModel()
        {
            NotStarted = new ObservableCollection<TodoItemModel>();
            InProgress = new ObservableCollection<TodoItemModel>();
            Completed = new ObservableCollection<TodoItemModel>();
        }

        public TodoListModel(IList<TodoItemModel> notStarted, IList<TodoItemModel> inProgress, IList<TodoItemModel> completed) 
        {
            NotStarted = new ObservableCollection<TodoItemModel>(notStarted);
            InProgress = new ObservableCollection<TodoItemModel>(inProgress);
            Completed = new ObservableCollection<TodoItemModel>(completed);
        }
    }
}
