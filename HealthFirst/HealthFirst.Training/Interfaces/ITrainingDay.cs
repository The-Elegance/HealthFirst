namespace HealthFirst.Core.Training.Interfaces
{
    public interface ITrainingDay
    {
        uint Id { get; }
        string Title { get; }
        bool IsDayOfRest { get; }
        IEnumerable<IExercise> Exercises { get; }
    }
}
