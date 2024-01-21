using HealthFirst.Core.Training.Interfaces;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public sealed class TrainingsListService : IDataListService<ITrainingCourse>
    {
        const string FilePath = "trainingCourses.json";
        private readonly JsonTool<IEnumerable<ITrainingCourse>> _jsonTool;

        public TrainingsListService(string path)
        {
            _jsonTool = new JsonTool<IEnumerable<ITrainingCourse>>(path, FilePath);
        }

        public void Write(IEnumerable<ITrainingCourse> trainingCourses)
        {
            _jsonTool.Serialize(trainingCourses);
        }

        public IEnumerable<ITrainingCourse> Read()
        {
            return _jsonTool.Deserialize();
        }
    }
}
