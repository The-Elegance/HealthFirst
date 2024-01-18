using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Media;
using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public class TrainingCourse : ITrainingCourse
    {
        private readonly string _toString;

        public uint Id { get; }
        public ICollection<ITrainingWeek> TrainingWeeks { get; }

        public IMediaObject HeaderMedia { get; }
        public CalendarObjectRepeatInfo CalendarInfo { get; }
        public ITrainingCourseInfo PresentaionInfo { get; }


        #region Constructors


        public TrainingCourse(uint id, ITrainingCourseInfo courseInfo, CalendarObjectRepeatInfo info, ICollection<ITrainingWeek> trainingWeeks)
        {
            Id = id;
            PresentaionInfo = courseInfo;
            CalendarInfo = info;

            TrainingWeeks = trainingWeeks;

            _toString = $"TrainingCourse {id}: {PresentaionInfo}, WeeksCount: {TrainingWeeks.Count}";
        }


        #endregion Constructors


        #region Public & Protected Methods


        public override string ToString()
        {
            return _toString;
        }


        #endregion Public & Protected Methods
    }
}
