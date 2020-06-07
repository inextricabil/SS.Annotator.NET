﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RTCoViD.Models
{
    public class DailyDeathsReport
    {
        [Key]
        public string DailyDeathsReportId { get; set; }
        public DateTime Date { get; set; }
        public long Value { get; set; }
        public Report Report { get; set; }
    }
}