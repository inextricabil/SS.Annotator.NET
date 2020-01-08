using System;

namespace TemporalToolkit.Utils
{
    public class DateDifference
    {
        /// <summary>
        ///     contain from date
        /// </summary>
        private readonly DateTime fromDate;

        /// <summary>
        ///     defining Number of days in month; index 0=> january and 11=> December
        ///     february contain either 28 or 29 days, that's why here value is -1
        ///     which wil be calculate later.
        /// </summary>
        private readonly int[] monthDay = new int[12] {31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

        /// <summary>
        ///     contain To Date
        /// </summary>
        private readonly DateTime toDate;

        public DateDifference(DateTime d1, DateTime d2)
        {
            int increment;

            if (d1 > d2)
            {
                fromDate = d2;
                toDate = d1;
            }
            else
            {
                fromDate = d1;
                toDate = d2;
            }

            /// 
            /// Day Calculation
            /// 
            increment = 0;

            if (fromDate.Day > toDate.Day) increment = monthDay[fromDate.Month - 1];
            /// if it is february month
            /// if it's to day is less then from day
            if (increment == -1)
            {
                if (DateTime.IsLeapYear(fromDate.Year))
                    // leap year february contain 29 days
                    increment = 29;
                else
                    increment = 28;
            }

            if (increment != 0)
            {
                Days = toDate.Day + increment - fromDate.Day;
                increment = 1;
            }
            else
            {
                Days = toDate.Day - fromDate.Day;
            }

            ///
            ///month calculation
            ///
            if (fromDate.Month + increment > toDate.Month)
            {
                Months = toDate.Month + 12 - (fromDate.Month + increment);
                increment = 1;
            }
            else
            {
                Months = toDate.Month - (fromDate.Month + increment);
                increment = 0;
            }

            ///
            /// year calculation
            ///
            Years = toDate.Year - (fromDate.Year + increment);
        }


        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

        public int TotalMonths => Years * 12 + Months;

        public override string ToString()
        {
            //return base.ToString();
            return Years + " Year(s), " + Months + " month(s), " + Days + " day(s)";
        }
    }
}