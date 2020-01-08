using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     After TE checks for dates after a specifed date.
    /// </summary>
    public class TEAfter : TemporalExpression
    {
        /// <summary>
        ///     Checks if dates are after a specified date
        /// </summary>
        /// <param name="aDate">Date to check against</param>
        public TEAfter(DateTime aDate)
        {
            Date = aDate;
        }

        public DateTime Date { get; set; }

        /// <summary>
        ///     Returns true if specified date is after the te date.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            return aDate > Date;
        }
    }
}