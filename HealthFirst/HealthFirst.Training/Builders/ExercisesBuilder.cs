using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training.Builders
{
    public class ExercisesBuilder
    {
        private uint _id = 0;
        private IExericePresentationInfo _presentationInfo;
        private ICollection<ISetOfExercise> _exercisesSet = new List<ISetOfExercise>();


        #region Constructors


        public ExercisesBuilder(uint id = 0)
        {
            _id = id;
        }


        #endregion Constructors


        public IExercise Build()
        {
            return new Exercise(_id, _presentationInfo, _exercisesSet);
        }


        public ExercisesBuilder Id(uint id)
        {
            _id = id;
            return this;
        }


        #region PresentationInfo


        public ExercisesBuilder AddPresentationInfo(IExericePresentationInfo exericePresentationInfo)
        {
            _presentationInfo = exericePresentationInfo;
            return this;
        }

        public ExercisesBuilder AddPresentationInfo(string title, string summary, string description, uint setsCount, uint repsCount, TimeSpan restTime)
        {
            _presentationInfo = new ExericePresentationInfo(title, summary, description, setsCount, repsCount, restTime);
            return this;
        }


        #endregion PresentationInfo


        #region Sets


        public ExercisesBuilder AddEmptySets(uint setsCount)
        {
            for (uint i = 0; i < setsCount; i++)
                _exercisesSet.Add(new SetOfExercise(i, 0));
            return this;
        }

        public ExercisesBuilder AddSets(uint setsCount, IList<uint> latestCounts)
        {
            if (latestCounts.Count == 0)
                return AddEmptySets(setsCount);

            for (uint i = 0; i < setsCount; i++)
            {
                ISetOfExercise setOfExercise;
                if (latestCounts.Count - 1 == i)
                    setOfExercise = new SetOfExercise(i, 0);
                else
                    setOfExercise = new SetOfExercise(i, latestCounts[0]);

                _exercisesSet.Add(setOfExercise);
            }

            return this;
        }

        public ExercisesBuilder AddOneSet(uint latestCount)
        {
            _exercisesSet.Add(new SetOfExercise((uint)_exercisesSet.Count, latestCount));
            return this;
        }


        #endregion Sets
    }
}
