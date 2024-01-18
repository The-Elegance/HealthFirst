namespace HealthFirst.Core.Training.Interfaces
{
    public interface ISetOfExercise
    {
        public uint Id { get; }
        public uint LatestCount { get; }
        public uint CurrentCount { get; set; }
        public bool IsCompleted { get; set; }
    }
}
