using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public class TrainingWeek : ITrainingWeek
    {
        public uint Id { get; }
        public bool IsComplited { get; }
        public IEnumerable<ITrainingDay> Days { get; }

        public TrainingWeek(uint id, bool isComplited, IEnumerable<ITrainingDay> days)
        {
            Id = id;
            IsComplited = isComplited;
            Days = days;
        }
    }
}
