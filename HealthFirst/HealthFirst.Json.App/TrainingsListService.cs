using HealthFirst.Core.Training.Interfaces;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public class TrainingsListService : IDataListService<ITrainingCourse>
    {
        private readonly JsonTool<IEnumerable<ITrainingCourse>> _jsonTool;
        private readonly string _path;

        public TrainingsListService(string path)
        {
            _path = path;
            _jsonTool = new JsonTool<IEnumerable<ITrainingCourse>>();
        }

        public void Write(IEnumerable<ITrainingCourse> trainingCourses)
        {
            _jsonTool.Serialize(trainingCourses, _path);
        }

        public IEnumerable<ITrainingCourse> Read()
        {
            return _jsonTool.Deserialize(_path);
        }
    }
}
