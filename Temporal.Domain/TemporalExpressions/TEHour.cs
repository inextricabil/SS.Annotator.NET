using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Temporal expression for checking hour, or span of hours.
    /// </summary>
    public class TEHour : TemporalExpression
    {
        /// <summary>
        ///     Matches the hour value of dates.
        /// </summary>
        /// <param name="hour"></param>
        public TEHour(int hour)
        {
            Start = hour;
            End = null;
        }

        /// <summary>
        ///     Matches a dates hour value with a range of dates
        /// </summary>
        /// <param name="startHour">Start of hour range</param>
        /// <param name="endHour">End of hour range</param>
        public TEHour(int startHour, int endHour)
        {
            Start = startHour;
            End = endHour;
        }

        public int Start { get; set; }
        public int? End { get; set; }

        /// <summary>
        ///     Returns true when hour/hour range matches specified dates hour.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            bool result;

            if (End.HasValue)
            {
                if (End.Value > Start)
                    result = aDate.Hour >= Start && aDate.Hour <= End.Value;
                else
                    result = aDate.Hour >= Start || aDate.Hour <= End.Value;
            }
            else
            {
                result = Start == aDate.Hour;
            }

            return result;
        }
    }
}