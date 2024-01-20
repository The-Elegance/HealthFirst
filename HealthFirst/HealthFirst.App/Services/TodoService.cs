using HealthFirst.App.Models.Todo;
using HealthFirst.Todo;
using HealthFirst.Json.App;

namespace HealthFirst.App.Services
{
    public class TodoService
    {
        const string FilePath = "todolist.json";

        private readonly TodoListService _todoListService;

        public TodoService()
        {
            _todoListService = new TodoListService(AppSettings.APP_FOLDER_NAME + "/" + FilePath);
        }

        public void SaveTodoModel(TodoListModel todoItemModels) 
        {
            var todoItems = new List<ITodoItem>();

            foreach (var todoItemModel in todoItemModels.GetAllTodoItems) 
            {
                var todoItem = new TodoItem(
                    todoItemModel.Title, 
                    todoItemModel.Description, 
                    todoItemModel.CreatedTime, 
                    todoItemModel.DeadlineTime, 
                    todoItemModel.Status, 
                    todoItemModel.Priority);

                todoItems.Add(todoItem);
            }

            _todoListService.Write(todoItems);
        }

        public TodoListModel GetTodoListModel()
        {
            var todoItems = _todoListService.Read();

            if (todoItems == null)
                return new TodoListModel();

            var todoListModel = new TodoListModel(
                    todoItems.Where(i => i.Status == Status.NotStarted).Select(i => new TodoItemModel(i)).ToList(),
                    todoItems.Where(i => i.Status == Status.InProgress).Select(i => new TodoItemModel(i)).ToList(),
                    todoItems.Where(i => i.Status == Status.Completed).Select(i => new TodoItemModel(i)).ToList());
            return todoListModel;
        }
    }
}
