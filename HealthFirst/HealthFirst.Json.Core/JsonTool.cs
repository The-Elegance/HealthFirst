using Newtonsoft.Json;

namespace HealthFirst.Json.Core
{
    public class JsonTool<T>
    {
        public JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };

        public void Serialize(object value, string path)
        {
            var json = JsonConvert.SerializeObject(value, Settings);
            File.WriteAllText(path, json, System.Text.Encoding.UTF8);
        }

        public T Deserialize(string path)
        {
            var data = File.ReadAllText(path, System.Text.Encoding.UTF8);
            return JsonConvert.DeserializeObject<T>(data, Settings);
        }

        public JsonTool()
        {

        }

        public JsonTool(JsonSerializerSettings settings) 
        {
            Settings = settings;
        }
    }
}
