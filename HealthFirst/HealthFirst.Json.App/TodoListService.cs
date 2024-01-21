using HealthFirst.Json.Core;
using HealthFirst.Todo;

namespace HealthFirst.Json.App
{
    public sealed class TodoListService : IDataListService<ITodoItem>
    {
        const string FilePath = "todolist.json";
        private readonly JsonTool<IEnumerable<ITodoItem>> _jsonTool;

        public TodoListService(string dirPath)
        {
            _jsonTool = new JsonTool<IEnumerable<ITodoItem>>(dirPath, FilePath);
        }

        public void Write(IEnumerable<ITodoItem> todoItems)
        {
            _jsonTool.Serialize(todoItems);
        }

        public IEnumerable<ITodoItem> Read()
        {
            return _jsonTool.Deserialize();
        }
    }
}
