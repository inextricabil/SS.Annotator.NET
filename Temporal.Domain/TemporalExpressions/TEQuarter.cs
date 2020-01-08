using System;
using Temporal.Domain.Extensions;

namespace Temporal.Domain.TemporalExpressions
{
    public class TEQuarter : TemporalExpression
    {
        /// <summary>
        ///     Checks for a single quarter assuming
        ///     the year starts Jan 1st
        /// </summary>
        /// <param name="quarter"></param>
        public TEQuarter(Quarter quarter)
        {
            Start = quarter;
            End = null;
            StartOfYear = Month.January;
        }

        /// <summary>
        ///     Checks for a range of quarters
        ///     assuming the year starts Jan 1st
        /// </summary>
        /// <param name="start">Start of range</param>
        /// <param name="end">End of range</param>
        public TEQuarter(Quarter start, Quarter end)
        {
            Start = start;
            End = end;
            StartOfYear = Month.January;
        }

        /// <summary>
        ///     Checks for a quarter based on specified
        ///     start of year.
        /// </summary>
        /// <param name="quarter"></param>
        /// <param name="startOfYear"></param>
        public TEQuarter(Quarter quarter, Month startOfYear)
        {
            Start = quarter;
            End = null;
            StartOfYear = startOfYear;
        }

        /// <summary>
        ///     Checks for range of quarters based on
        ///     specified start of year
        /// </summary>
        /// <param name="start">Start of range</param>
        /// <param name="end">End of range</param>
        /// <param name="startOfYear"></param>
        public TEQuarter(Quarter start, Quarter end, Month startOfYear)
        {
            Start = start;
            End = end;
            StartOfYear = startOfYear;
        }

        public Quarter Start { get; set; }
        public Quarter? End { get; set; }
        public Month StartOfYear { get; set; }

        /// <summary>
        ///     Returns true if date falls on specified quarter or range of quarters
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            //check for valid args
            if (Start == Quarter.Unset || End.HasValue && End.Value == Quarter.Unset)
                throw new ArgumentException();

            bool result;

            if (End.HasValue)
            {
                //range
                if (End.Value >= Start)
                    result = aDate.Quarter(StartOfYear) <= End.Value && aDate.Quarter(StartOfYear) >= Start;
                else
                    result = aDate.Quarter(StartOfYear) <= End.Value || aDate.Quarter(StartOfYear) >= Start;
            }
            else
            {
                result = Start == aDate.Quarter(StartOfYear);
            }

            return result;
        }
    }
}