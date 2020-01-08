using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Before TE checks if dates occurr after a specified date.
    /// </summary>
    public class TEBefore : TemporalExpression
    {
        /// <summary>
        ///     Checks if dates occurr after given date
        /// </summary>
        /// <param name="aDate">Date to test against</param>
        public TEBefore(DateTime aDate)
        {
            Date = aDate;
        }

        public DateTime Date { get; set; }

        /// <summary>
        ///     Returns true if passed date is after te date.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            return aDate < Date;
        }
    }
}