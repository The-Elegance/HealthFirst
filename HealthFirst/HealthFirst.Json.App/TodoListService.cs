using HealthFirst.Todo;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public class TodoListService
    {
        private readonly JsonTool<IEnumerable<ITodoItem>> _jsonTool;
        public TodoListService()
        {
            _jsonTool = new JsonTool<IEnumerable<ITodoItem>>();
        }

        public void Write(IEnumerable<ITodoItem> todoItems) 
        {
            _jsonTool.Serialize(todoItems, "N:\\VirtualStand\\Data\\todolist.json");
        }

        public IEnumerable<ITodoItem> Read() 
        {
            return _jsonTool.Deserialize("N:\\VirtualStand\\Data\\todolist.json");
        }
    }
}
