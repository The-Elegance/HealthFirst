namespace HealthFirst.Core.CalendarObject
{
    public readonly struct CalendarObjectRepeatInfo(
        CalendarObjectRepeat type,
        uint every,
        DateTime starts,
        DateTime createAt,
        TimeZoneInfo timeZoneInfo,
        DayOfWeek[] selectedDayOfWeek = null)
    {
        /// <summary>
        /// Type of repeats list Weekly, Daily...
        /// </summary>
        public readonly CalendarObjectRepeat Type = type;
        /// <summary>
        /// Every x days, weeks, months, years...
        /// Every = 2 (days) -> Mon, Wen, Fri, Sat...
        /// </summary>
        public readonly uint Every = every;
        /// <summary>
        /// Starts from next avaiable data.
        /// </summary>
        public readonly DateTime Starts = starts;
        /// <summary>
        /// Create at this time.
        /// </summary>
        public readonly DateTime CreateAt = createAt;
        /// <summary>
        /// Time Zone (GMT +-...)
        /// </summary>
        public readonly TimeZoneInfo TimeZone = timeZoneInfo;
        /// <summary>
        /// Selected Day of Week.
        /// For Type - Weekly only!
        /// </summary>
        public readonly DayOfWeek[] SelectedDayOfWeek = selectedDayOfWeek;
    }
}
