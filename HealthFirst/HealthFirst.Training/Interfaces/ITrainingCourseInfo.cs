using HealthFirst.Core.Media;

namespace HealthFirst.Core.Training.Interfaces
{
    public interface ITrainingCourseInfo
    {
        /// <summary>
        /// Name of Training Course.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Description of Training Course.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Short description of Training Course.
        /// </summary>
        public string Summary { get; }

        /// <summary>
        /// Header Media
        /// </summary>
        public IMediaObject HeaderMedia { get; }
    }
}
