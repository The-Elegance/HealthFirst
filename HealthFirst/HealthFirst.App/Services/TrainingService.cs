using HealthFirst.App.Models.Training;
using HealthFirst.Core.Training;
using HealthFirst.Core.Training.Interfaces;
using HealthFirst.Json.App;

namespace HealthFirst.App.Services
{
    public class TrainingService
    {
        const string FilePath = "trainingCourses.json";
      
        private readonly TrainingsListService _trainingListService;

        public TrainingService()
        {
            _trainingListService = new TrainingsListService(AppSettings.APP_FOLDER_NAME + "/" + FilePath);
        }

        public void SaveTrainingModel(TrainingsModel model) 
        {
            var trainings = new List<ITrainingCourse>();

            uint i = 0;
            foreach (var tc in model.Courses) 
            {
                var newTc = new TrainingCourse(i, tc.PresentaionInfo, tc.CalendarInfo, tc.TrainingWeeks);
                trainings.Add(newTc);
                i++;
            }

            _trainingListService.Write(trainings);
        }

        public TrainingsModel GetTrainingModel() 
        {
            var list = _trainingListService.Read();
            return new TrainingsModel(list);
        }
    }
}
