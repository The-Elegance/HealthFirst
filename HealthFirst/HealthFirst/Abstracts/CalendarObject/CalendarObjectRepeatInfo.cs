namespace HealthFirst.Core.CalendarObject
{
    public readonly struct CalendarObjectRepeatInfo
    {
        /// <summary>
        /// Type of repeats list Weekly, Daily...
        /// </summary>
        public readonly CalendarObjectRepeat Type;
        /// <summary>
        /// Every x days, weeks, months, years...
        /// Every = 2 (days) -> Mon, Wen, Fri, Sat...
        /// </summary>
        public readonly uint Every;
        /// <summary>
        /// Starts from next avaiable data.
        /// </summary>
        public readonly DateTime Starts;
        /// <summary>
        /// Create at this time.
        /// </summary>
        public readonly DateTime CreateAt;
        /// <summary>
        /// Time Zone (GMT +-...)
        /// </summary>
        public readonly TimeZoneInfo TimeZone;
        /// <summary>
        /// Selected Day of Week.
        /// For Type - Weekly only!
        /// </summary>
        public readonly DayOfWeek[] SelectedDayOfWeek;
    }
}
