namespace HealthFirst.Core.Timer
{
    public readonly struct TimerPausedData(TimeSpan remainingTime, TimeSpan passedTime)
    {
        public readonly TimeSpan RemainingTime = remainingTime;
        public readonly TimeSpan PassedTime = passedTime;
    }
}
