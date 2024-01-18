using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Training.Interfaces;
using HealthFirst.Core.Training;

namespace HealthFirst.Training.Builders
{
    public sealed class TrainingCourseBuilder
    {
        private uint _id;
        private ITrainingCourseInfo _courseInfo;
        private CalendarObjectRepeatInfo _calendarInfo;
        private ICollection<ITrainingWeek> _trainingWeeks;

        public TrainingCourseBuilder AddTrainingCourseInfo()
        {
            return this;
        }

        public TrainingCourseBuilder AddTrainingWeek(ITrainingWeek trainingWeek)
        {
            _trainingWeeks.Add(trainingWeek);
            return this;
        }

        public ITrainingCourse Build()
        {
            return new TrainingCourse(_id, _courseInfo, _calendarInfo, _trainingWeeks);
        }
    }
}
