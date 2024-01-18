using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public class TrainingDay : ITrainingDay
    {
        public uint Id { get; }
        public string Title { get; }
        public bool IsDayOfRest { get; }
        public IEnumerable<IExercise> Exercises { get; }

        public TrainingDay(uint id, string title, bool isDayOfRest, IEnumerable<IExercise> exercises)
        {
            Id = id;
            Title = title;
            IsDayOfRest = isDayOfRest;
            Exercises = exercises;
        }
    }
}
