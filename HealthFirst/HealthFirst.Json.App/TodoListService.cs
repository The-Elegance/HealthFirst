using HealthFirst.Todo;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public class TodoListService : IDataListService<ITodoItem>
    {
        private readonly JsonTool<IEnumerable<ITodoItem>> _jsonTool;
        private readonly string _path;

        public TodoListService(string path)
        {
            _path = path;
            _jsonTool = new JsonTool<IEnumerable<ITodoItem>>();
        }

        public void Write(IEnumerable<ITodoItem> todoItems) 
        {
            _jsonTool.Serialize(todoItems, _path);
        }

        public IEnumerable<ITodoItem> Read() 
        {
            return _jsonTool.Deserialize(_path);
        }
    }
}
