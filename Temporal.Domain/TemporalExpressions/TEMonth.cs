using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Compares month or range of months, E.g: February or Feb-March
    /// </summary>
    public class TEMonth : TemporalExpression
    {
        /// <summary>
        ///     Checks for month match based on month of specified date.
        /// </summary>
        /// <param name="month"></param>
        public TEMonth(DateTime date)
        {
            Start = Month.January;
            End = null;
        }

        /// <summary>
        ///     Checks for month match, month should be 1-12 value
        /// </summary>
        /// <param name="month"></param>
        public TEMonth(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException("month");

            Start = (Month) month;
            End = null;
        }

        /// <summary>
        ///     Checks for month match.
        /// </summary>
        /// <param name="month"></param>
        public TEMonth(Month month)
        {
            Start = month;
            End = null;
        }

        /// <summary>
        ///     Checks for a month range
        /// </summary>
        /// <param name="start">Start of range</param>
        /// <param name="end">End of range</param>
        public TEMonth(Month start, Month end)
        {
            Start = start;
            End = end;
        }

        public Month Start { get; set; }
        public Month? End { get; set; }


        /// <summary>
        ///     Returns true if month matches or is in range of months
        /// </summary>
        /// <param name="aDate">Date to compare</param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            if (End.HasValue)
            {
                if (End.Value >= Start)
                    return aDate.Month <= (int) End.Value && aDate.Month >= (int) Start;
                return aDate.Month <= (int) End.Value || aDate.Month >= (int) Start;
            }

            return (int) Start == aDate.Month;
        }
    }
}