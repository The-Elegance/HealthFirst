using HealthFirst.App.Services;
using HealthFirst.Core.Training.Interfaces;
using System.Collections.ObjectModel;

namespace HealthFirst.App.Models.Training
{
    public sealed class TrainingsModel
    {
        public ObservableCollection<ITrainingCourse> Courses { get; }

        public TrainingsModel()
        {
            Courses = [];
        }

        public TrainingsModel(IEnumerable<ITrainingCourse> courses)
        {
            Courses = new ObservableCollection<ITrainingCourse>(courses);
        }

        public void AddCourse(ITrainingCourse course)
        {
            Courses.Add(course);
        }

        public void RemoveCourse(ITrainingCourse course)
        {
            Courses.Remove(course);
        }

        public void SaveCourse()
        {
            var trainingService = new TrainingService();
            trainingService.SaveTrainingModel(this);
        }
    }
}
