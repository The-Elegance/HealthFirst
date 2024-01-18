using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public struct SetOfExercise : ISetOfExercise
    {
        public uint Id { get; }
        public uint LatestCount { get; }
        public uint CurrentCount { get; set; } = 0;
        public bool IsCompleted { get; set; } = false;

        public SetOfExercise(uint id, uint latestCount)
        {
            Id = id;
            LatestCount = latestCount;
        }

        public override string ToString()
        {
            return $"SetOfExercise {Id}: LatestCount: {LatestCount}, CurrentCount: {CurrentCount}, IsCompleted: {IsCompleted}";
        }
    }
}
