using System;

namespace Temporal.Domain.TemporalExpressions
{
    /// <summary>
    ///     Temporal expression for seconds
    /// </summary>
    public class TESecond : TemporalExpression
    {
        /// <summary>
        ///     Check for specified seconds value
        /// </summary>
        /// <param name="second"></param>
        public TESecond(int second)
        {
            Start = second;
            End = null;
        }

        /// <summary>
        ///     Check for a specified range of seconds
        /// </summary>
        /// <param name="start">Start of range</param>
        /// <param name="end">End of range</param>
        public TESecond(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; set; }
        public int? End { get; set; }


        /// <summary>
        ///     Returns true if seconds match or fall within range.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            bool result;

            if (End.HasValue)
                if (End.Value > Start)
                    result = aDate.Second >= Start && aDate.Second <= End.Value;
                else
                    result = aDate.Second >= Start || aDate.Second <= End.Value;
            else
                result = Start == aDate.Second;

            return result;
        }
    }
}