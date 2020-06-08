using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RTCoViD.Models
{
    public class Report
    {
        [Key]
        public string ReportId { get; set; }
        [Name("Province/State")]
        public string Province { get; set; }
        [Name("Country/Region")]
        public string Country { get; set; }
        [Name("Lat")]
        public string Latitude { get; set; }
        [Name("Long")]
        public string Longitude { get; set; }

        public ICollection<DailyConfirmedReport> DailyConfirmedReports { get; set; }
        public ICollection<DailyDeathsReport> DailyDeathsReports { get; set; }
        public ICollection<DailyRecoveredReport> DailyRecoveredReports { get; set; }

    }
}
