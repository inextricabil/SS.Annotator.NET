﻿using System;

namespace Temporal.Domain.Extensions
{
    public static class DateExtensions
    {
        /// <summary>
        ///     Returns the occurrence of the day in the month as an integer e.g. 4th wednesday in month.
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public static int OccurrenceOfDayInMonth(this DateTime aDate)
        {
            return (aDate.Day - 1) / 7 + 1;
        }

        /// <summary>
        ///     Returns start of the week assuming the week starts on saturday
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public static DateTime StartOfWeek(this DateTime aDate)
        {
            var offset = (int) aDate.DayOfWeek * -1;
            var temp = aDate.AddDays(offset);
            return new DateTime(temp.Year, temp.Month, temp.Day);
        }


        /// <summary>
        ///     Returns the end of the week assuming the week ends on sunday
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public static DateTime EndOfWeek(this DateTime aDate)
        {
            var offset = 6 - (int) aDate.DayOfWeek;
            var temp = aDate.AddDays(offset);
            return new DateTime(temp.Year, temp.Month, temp.Day);
        }

        /// <summary>
        ///     Returns the quater the date is in, assuming
        ///     the year starts jan 1st
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public static Quarter Quarter(this DateTime aDate)
        {
            return aDate.Quarter(Month.January);
        }

        /// <summary>
        ///     Returns quarter date is in based on specifed
        ///     start of year
        /// </summary>
        /// <param name="aDate"></param>
        /// <param name="startOfQuarter">Start of the year</param>
        /// <returns></returns>
        public static Quarter Quarter(this DateTime aDate, Month startOfYear)
        {
            int offset;
            offset = ((int) startOfYear - 1) * -1 + aDate.Month;
            if (offset <= 0) offset = 12 - Math.Abs(offset);
            return (Quarter) Math.Ceiling((double) (offset / 3M));
        }
    }
}