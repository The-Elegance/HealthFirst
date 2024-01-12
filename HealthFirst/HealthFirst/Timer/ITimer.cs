namespace HealthFirst.Core.Timer
{
    public delegate void PausedTimerCallback(TimerPausedData data);

    public interface ITimer
    {
        /// <summary>
        /// Timer has started.
        /// </summary>
        public event PausedTimerCallback Started;
        /// <summary>
        /// Timer has paused.
        /// </summary>
        public event PausedTimerCallback Paused;
        /// <summary>
        /// Timer has finished.
        /// </summary>
        public event Action Finished;
        /// <summary>
        /// Start time work.
        /// </summary>
        /// <returns></returns>
        public Task Start();
        /// <summary>
        /// Stop the active timer.
        /// </summary>
        public void Stop();
    }
}
