using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using RTCoViD.Models;

namespace RTCoViD.Services
{
    public class ReportParser : IReportParser
    {

        public IEnumerable<string> GetAllReportsPath()
        {

            var reportsFilesFolder = "Data" + Path.DirectorySeparatorChar + "reports";
            var reportsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), reportsFilesFolder);
            var reportFiles = Directory.EnumerateFiles(reportsFilesFolderPath, "*.csv*", SearchOption.AllDirectories);
            return reportFiles;
        }

        public IList<Report> GetReports()
        {
            var reportFilesPath = GetAllReportsPath();
            var reports = new List<Report>();
            foreach (var reportFiePath in reportFilesPath)
            {
                using (TextReader reader = File.OpenText(reportFiePath))
                {
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.MissingFieldFound = null;
                    csv.Configuration.HeaderValidated = null;
                    while (csv.Read())
                    {
                        var report = csv.GetRecord<Report>();
                        tweet.TweetId = Guid.NewGuid().ToString();
                        tweets.Add(tweet);
                    }
                }
            }
            return tweets;
            //var deathsReportsFilePath = GetDeathsReportFilePath();
            //var reports = new List<Report>();
            //using (TextReader reader = File.OpenText(deathsReportsFilePath))
            //{
            //    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            //    csv.Configuration.Delimiter = ",";
            //    csv.Configuration.MissingFieldFound = null;
            //    csv.Configuration.HeaderValidated = null;
            //    while (csv.Read())
            //    {
            //        var report = csv.GetRecord<Report>();
            //        report.ReportId = Guid.NewGuid().ToString();
            //        report.DailyDeathsReports = new List<DailyDeathsReport>();
            //        foreach (var column in csv.Context.HeaderRecord)
            //        {
            //            if (column == "Province/State" || column == "Country/Region" || column == "Lat" ||
            //                column == "Long")
            //            {
            //                continue;
            //            }

            //            var dailyDeathsReport = new DailyDeathsReport()
            //            {
            //                DailyDeathsReportId = Guid.NewGuid().ToString(),
            //                Date = DateTime.Parse(column),
            //                Report = report,
            //                Value = long.Parse(csv.GetField(column))
            //            };

            //            report.DailyDeathsReports.Add(dailyDeathsReport);
            //        }
            //        reports.Add(report);
            //    }
            //}

            //return reports;
        }
    }

    public interface IReportParser
    {
        IEnumerable<string> GetAllReportsPath();
        IList<Report> GetReports();
    }
}
