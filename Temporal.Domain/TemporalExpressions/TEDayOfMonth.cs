using System;
using Temporal.Domain.Extensions;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Day of month temporal expression checks for a day of the month
    ///     e.g: the 4th tuesday
    /// </summary>
    public class TEDayOfMonth : TemporalExpression
    {
        /// <summary>
        ///     Checks for day of month for specified date
        /// </summary>
        /// <param name="day">Day of week</param>
        /// <param name="occurrence">
        ///     Occurrence of day in the month. Use negative integers to
        ///     count from end of month. e.g -1 = last occurrence
        /// </param>
        public TEDayOfMonth(DateTime date)
        {
            Day = date.DayOfWeek;
            Occurrence = date.OccurrenceOfDayInMonth();
        }

        /// <summary>
        /// </summary>
        /// <param name="day">Day of week</param>
        /// <param name="occurrence">
        ///     Occurrence of day in the month. Use negative integers to
        ///     count from end of month. e.g -1 = last occurrence
        /// </param>
        public TEDayOfMonth(DayOfWeek day, int occurrence)
        {
            Day = day;
            Occurrence = occurrence;
        }

        public DayOfWeek Day { get; set; }
        public int Occurrence { get; set; }

        /// <summary>
        ///     Returns true if occurence of day and day of week match
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            if (Occurrence < 0)
            {
                var index = DateTime.DaysInMonth(aDate.Year, aDate.Month) - aDate.Day + 1;
                index = (index - 1) / 7 + 1;
                return aDate.DayOfWeek == Day && index == Math.Abs(Occurrence);
            }

            return aDate.DayOfWeek == Day && aDate.OccurrenceOfDayInMonth() == Occurrence;
        }
    }
}