using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Expression for day of month
    /// </summary>
    public class TEDayInMonth : TemporalExpression
    {
        /// <summary>
        ///     Checks for day of month
        /// </summary>
        public TEDayInMonth(DateTime date)
        {
            Start = date.Day;
            End = null;
        }

        /// <summary>
        ///     Checks for day of month, if negative number is passed
        ///     it will count days from end of month.
        /// </summary>
        /// <param name="day">Day of month to check</param>
        public TEDayInMonth(int day)
        {
            Start = day;
            End = null;
        }

        /// <summary>
        ///     Checks for a day range of a month
        /// </summary>
        /// <param name="start">Start of day range</param>
        /// <param name="end">End of day range</param>
        public TEDayInMonth(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int? End { get; set; }

        /// <summary>
        ///     Returns true if day of month matches or is in range.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            bool result;

            if (End.HasValue)
            {
                if (Start > End.Value) throw new ArgumentException("Start of range must be less than end of range");
                result = aDate.Day >= Start && aDate.Day <= End.Value;
            }
            else
            {
                //count from end of month if negative number
                if (Start > 0)
                    result = aDate.Day == Start;
                else
                    result = DateTime.DaysInMonth(aDate.Year, aDate.Month) + Start + 1 == aDate.Day;
            }

            return result;
        }
    }
}