using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public readonly struct ExericePresentationInfo(
        string title,
        string summary,
        string description,
        uint setsCount,
        uint repsCount,
        TimeSpan restTime
        ) : IExericePresentationInfo
    {
        public string Title { get; } = title;
        public string Description { get; } = description;
        public string Summary { get; } = summary;
        public uint SetsCount { get; } = setsCount;
        public uint RepsCount { get; } = repsCount;
        public TimeSpan RestTime { get; } = restTime;

        public override string ToString()
        {
            return $"Title: {Title}, Summary: {Summary}, Description: {Description}, SetsCount: {SetsCount}, RepsCount: {RepsCount}, RestTime: {RestTime.TotalSeconds}s";
        }
    }
}
