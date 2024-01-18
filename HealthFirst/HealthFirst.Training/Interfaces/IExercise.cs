namespace HealthFirst.Core.Training.Interfaces
{
    public interface IExercise
    {
        /// <summary>
        /// Id of Exercies
        /// </summary>
        public uint Id { get; }
        /// <summary>
        /// Exercies info (Title, Summary, etc...)
        /// </summary>
        public IExericePresentationInfo PresentaionInfo { get; }
        /// <summary>
        /// Collection of user set of exercise.
        /// </summary>
        public ICollection<ISetOfExercise> SetsOfExercise { get; }
    }
}
