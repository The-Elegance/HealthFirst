using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Media;

namespace HealthFirst.Core.Training.Interfaces
{
    public interface ITrainingCourse : ICalendarObject
    {
        public uint Id { get; }
        public ICollection<ITrainingWeek> TrainingWeeks { get; }
        public ITrainingCourseInfo PresentaionInfo { get; }
    }
}
