using System.Diagnostics;

namespace HealthFirst.Core.Timer
{
    public class WorkSessionTimer : ITimer
    {
        public event PausedTimerCallback Started;
        public event PausedTimerCallback Paused;
        public event Action Finished;
        
        private readonly TimeSpan _duration;

        private TimeSpan _remainingTime;
        private Stopwatch _stopwatch;


        #region Constructors


        public WorkSessionTimer(TimeSpan duration)
        {
            _duration = duration;
            _remainingTime = duration;
            _stopwatch = new Stopwatch();
        }


        #endregion Constructors


        #region Public Methods


        /// <summary>
        /// Start the work.
        /// </summary>
        /// <returns></returns>
        public async Task Start()
        {
            await Task.Run(() => 
            {
                _stopwatch.Start();
                Started?.Invoke(new TimerPausedData(_remainingTime, TimeSpan.FromTicks(_stopwatch.ElapsedTicks)));

                Thread.Sleep((int)_remainingTime.TotalMilliseconds);

                _stopwatch.Stop();
                Finished?.Invoke();
                _stopwatch.Reset();
            });
        }

        /// <summary>
        /// Stop the timer.
        /// </summary>
        public void Stop()
        {
            _stopwatch?.Stop();
            _remainingTime = TimeSpan.FromTicks(_duration.Ticks - _stopwatch.ElapsedTicks);
            Paused?.Invoke(new TimerPausedData(_remainingTime, TimeSpan.FromTicks(_stopwatch.ElapsedTicks)));
        }

        #endregion Public Methods
    }
}
