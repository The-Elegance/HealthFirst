namespace HealthFirst.Core.Training.Interfaces
{
    public interface IExericePresentationInfo
    {
        public string Title { get; }
        public string Description { get; }
        public string Summary { get; }
        /// <summary>
        /// Sets count of exercies. 
        /// </summary>
        public uint SetsCount { get; }
        /// <summary>
        /// Repetition count of exercies.
        /// </summary>
        public uint RepsCount { get; }
        /// <summary>
        /// Time of rest between sets in seconds.
        /// </summary>
        public TimeSpan RestTime { get; }
    }
}
