namespace HealthFirst.Core.Media
{
    public interface IMediaObject
    {
        /// <summary>
        /// Title of media file.
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// Description of media file.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Type of media file.
        /// Gif, Image, Video.
        /// </summary>
        public MediaObjectType Type { get; }
        /// <summary>
        /// Path to media File.
        /// </summary>
        public Uri FilePath { get; }
    }
}
