using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Checks for a single or range of week days
    ///     E.g. monday, or monday-friday
    /// </summary>
    public class TEWeekDay : TemporalExpression
    {
        /// <summary>
        ///     Checks a single day, e.g. Monday
        /// </summary>
        /// <param name="date">date to compare</param>
        public TEWeekDay(DateTime date)
        {
            Start = date.DayOfWeek;
            End = null;
        }


        /// <summary>
        ///     Checks a single day, e.g. Monday
        /// </summary>
        /// <param name="day">Day to compare</param>
        public TEWeekDay(DayOfWeek day)
        {
            Start = day;
            End = null;
        }

        /// <summary>
        ///     Checks for a range of weekdays, e.g. wed-sun
        /// </summary>
        /// <param name="start">Start of range</param>
        /// <param name="end">End of range</param>
        public TEWeekDay(DayOfWeek start, DayOfWeek end)
        {
            Start = start;
            End = end;
        }

        public DayOfWeek Start { get; set; }
        public DayOfWeek? End { get; set; }

        /// <summary>
        ///     Returns true if specified date occurrs on day of week or
        ///     range of days of week
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            bool result;

            if (End.HasValue)
            {
                //range
                if (End.Value >= Start)
                    result = aDate.DayOfWeek <= End.Value && aDate.DayOfWeek >= Start;
                else
                    result = aDate.DayOfWeek <= End.Value || aDate.DayOfWeek >= Start;
            }
            else
            {
                result = Start == aDate.DayOfWeek;
            }

            return result;
        }
    }
}