using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public class Exercise : IExercise
    {
        private readonly string _toString;

        public uint Id { get; }
        public IExericePresentationInfo PresentaionInfo { get; }
        public ICollection<ISetOfExercise> SetsOfExercise { get; }

        public Exercise(uint id, IExericePresentationInfo presentationInfo, ICollection<ISetOfExercise> setOfExercise)
        {
            Id = id;
            PresentaionInfo= presentationInfo;
            SetsOfExercise = setOfExercise;

            _toString = $"Exercise {id}: PresentaionInfo: {presentationInfo}, SetsOfExercise: {SetsOfExercise}";
        }

        public override string ToString()
        {
            return _toString;
        }
    }
}
