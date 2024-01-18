namespace HealthFirst.Core.Media
{
    public interface IMediaObject
    {
        /// <summary>
        /// Title of media file.
        /// </summary>
        string Title { get; }
        /// <summary>
        /// Description of media file.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Type of media file.
        /// Gif, Image, Video.
        /// </summary>
        MediaObjectType Type { get; }
        /// <summary>
        /// Path to media File.
        /// </summary>
        Uri FilePath { get; }
    }
}
