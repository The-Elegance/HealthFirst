namespace HealthFirst.Core.Training.Interfaces
{
    public interface ITrainingWeek
    {
        public uint Id { get; }
        public bool IsComplited { get; }
        public IEnumerable<ITrainingDay> Days { get; }
    }
}
