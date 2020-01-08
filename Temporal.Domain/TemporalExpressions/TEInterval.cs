using System;
using Temporal.Domain.Extensions;
using TemporalToolkit.Utils;

namespace Temporal.Domain.TemporalExpressions
{
    public class TEInterval : TemporalExpression
    {
        public int Interval;
        public DateTime Start;

        /// <summary>
        ///     Checks wheter dates occurr on an interval
        /// </summary>
        /// <param name="start">Date to count the intervals from</param>
        /// <param name="interval">Interval</param>
        /// <param name="precision"></param>
        public TEInterval(DateTime start, int interval, IntervalPrecision precision)
        {
            Precision = precision;
            Start = start;
            Interval = interval;
        }

        public IntervalPrecision Precision { get; set; }

        /// <summary>
        ///     Returns true when specified date falls on specified interval.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public override bool Includes(DateTime aDate)
        {
            if (aDate < Start) return false;


            switch (Precision)
            {
                case IntervalPrecision.Seconds:
                {
                    var ts = Start - aDate;
                    return ts.Seconds % Interval == 0;
                }
                case IntervalPrecision.Minutes:
                {
                    var ts = Start - aDate;
                    return ts.Minutes % Interval == 0;
                }
                case IntervalPrecision.Hours:
                {
                    var ts = Start - aDate;
                    return ts.Hours % Interval == 0;
                }
                case IntervalPrecision.Days:
                {
                    var tempStart = new DateTime(Start.Year, Start.Month, Start.Day);
                    var tempend = new DateTime(aDate.Year, aDate.Month, aDate.Day);
                    var ts = tempStart - aDate;
                    return ts.Days % Interval == 0;
                }
                case IntervalPrecision.Weeks:
                {
                    var tempStart = new DateTime(Start.Year, Start.Month, Start.Day).StartOfWeek();
                    var tempdate = new DateTime(aDate.Year, aDate.Month, aDate.Day).StartOfWeek();
                    var ts = tempStart - tempdate;
                    return ts.Days % (Interval * 7) == 0;
                }
                case IntervalPrecision.Months:
                {
                    var de = new DateDifference(Start, aDate);
                    return de.TotalMonths % Interval == 0;
                }
                //case IntervalPrecision.Quarters:
                //    {
                //        DateDifference de = new DateDifference(this.Start, aDate);
                //        return ((de.TotalMonths % (this.Interval * 3)) == 0);
                //    }
                case IntervalPrecision.Years:
                {
                    var de = new DateDifference(Start, aDate);
                    return de.Years % Interval == 0;
                }
                default:
                    throw new NotImplementedException();
            }
        }
    }
}