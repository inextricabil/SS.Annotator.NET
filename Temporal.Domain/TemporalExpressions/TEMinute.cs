using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Temporal expression for checking minute
    /// </summary>
    public class TEMinute : TemporalExpression
    {
        /// <summary>
        ///     Check if minutes match
        /// </summary>
        /// <param name="minute"></param>
        public TEMinute(int minute)
        {
            Start = minute;
            End = null;
        }

        /// <summary>
        ///     Check of minutes fall within a range
        /// </summary>
        /// <param name="start">Start of minute range</param>
        /// <param name="end">End of minute range</param>
        public TEMinute(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int? End { get; set; }

        /// <summary>
        ///     Returns true if minutes match or fall within range
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            bool result;

            if (End.HasValue)
                if (End.Value > Start)
                    result = aDate.Minute >= Start && aDate.Minute <= End.Value;
                else
                    result = aDate.Minute >= Start || aDate.Minute <= End.Value;
            else
                result = Start == aDate.Minute;

            return result;
        }
    }
}