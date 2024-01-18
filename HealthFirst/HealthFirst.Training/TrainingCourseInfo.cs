using HealthFirst.Core.Media;
using HealthFirst.Core.Training.Interfaces;

namespace HealthFirst.Core.Training
{
    public readonly struct TrainingCourseInfo(
        string name, 
        string description, 
        string summary,
        IMediaObject headerMedia
        ) : ITrainingCourseInfo
    {
        public string Name { get; } = name;
        public string Description { get; } = description;
        public string Summary { get; } = summary;
        public IMediaObject HeaderMedia { get; } = headerMedia;


        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Summary: {Summary}";
        }
    }
}
