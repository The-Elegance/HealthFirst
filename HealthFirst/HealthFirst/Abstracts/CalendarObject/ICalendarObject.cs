namespace HealthFirst.Core.CalendarObject
{
    public interface ICalendarObject
    {
        /// <summary>
        /// Info about where object must be in the calendar.
        /// </summary>
        CalendarObjectRepeatInfo Info { get; set; }
    }
}
