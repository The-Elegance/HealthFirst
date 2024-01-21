using Newtonsoft.Json;
using System.IO;

namespace HealthFirst.Json.Core
{
    public sealed class JsonTool<T>
    {
        private readonly string _path;

        public JsonSerializerSettings Settings { get; } = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        };


        #region Constructors


        public JsonTool(string path, string fileName)
        {
            // if file not exists, will create it
            var dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
                dirInfo.Create();

            _path = path + "\\" + fileName;
            if (!File.Exists(_path)) 
            { 
                using StreamWriter _ = File.AppendText(_path);
            }
        }

        public JsonTool(string path, string fileName, JsonSerializerSettings settings) : this(path, fileName)
        {
            Settings = settings;
        }


        #endregion Constructors


        #region Public Methods


        public void Serialize(object value) 
        {
            JsonTool<T>.Serialize(value, _path, Settings);
        }

        public T Deserialize() 
        {
            return JsonTool<T>.Deserialize(_path, Settings);
        }


        #endregion Public Methods


        #region Static Methods


        public static void Serialize(object value, string path, JsonSerializerSettings settings)
        {
            var json = JsonConvert.SerializeObject(value, settings);
            File.WriteAllText(path, json, System.Text.Encoding.UTF8);
        }

        public static T Deserialize(string path, JsonSerializerSettings settings)
        {
            var data = File.ReadAllText(path, System.Text.Encoding.UTF8);
            return JsonConvert.DeserializeObject<T>(data, settings);
        }


        #endregion Static Methods
    }
}
