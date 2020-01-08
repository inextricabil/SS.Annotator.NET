using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Compares a year or range of years
    /// </summary>
    public class TEYear : TemporalExpression
    {
        /// <summary>
        ///     Compares a year, E.g 2009
        /// </summary>
        /// <param name="year">Year to compare</param>
        public TEYear(int year)
        {
            Start = year;
        }

        /// <summary>
        ///     Compares a range of years, E.g 2001-2010
        /// </summary>
        /// <param name="start">Start of year range</param>
        /// <param name="end">End of year range</param>
        public TEYear(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int? End { get; set; }

        /// <summary>
        ///     Returns true if the date year matches or year is in range
        /// </summary>
        /// <param name="aDate">Date to check</param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            if (End.HasValue)
            {
                if (End < Start) throw new ArgumentException();
                return aDate.Year >= Start && aDate.Year <= End;
            }

            return aDate.Year == Start;
        }
    }
}