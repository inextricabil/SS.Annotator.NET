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

        public string GetConfirmedReportFilePath()
        {
            var reportsFilesFolder = "Data" + Path.DirectorySeparatorChar + "reports";
            var reportsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), reportsFilesFolder,
                "time_series_covid19_confirmed_global.csv");
            return reportsFilesFolderPath;
        }

        public string GetRecoveredReportFilePath()
        {
            var reportsFilesFolder = "Data" + Path.DirectorySeparatorChar + "reports";
            var reportsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), reportsFilesFolder,
                "time_series_covid19_recovered_global.csv");
            return reportsFilesFolderPath;
        }

        public string GetDeathsReportFilePath()
        {
            var reportsFilesFolder = "Data" + Path.DirectorySeparatorChar + "reports";
            var reportsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), reportsFilesFolder,
                "time_series_covid19_deaths_global.csv");
            return reportsFilesFolderPath;
        }

        public IList<Report> GetConfirmedReports()
        {
            var confirmedReportsFilePath = GetConfirmedReportFilePath();
            var reports = new List<Report>();
            using (TextReader reader = File.OpenText(confirmedReportsFilePath))
            {
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.HeaderValidated = null;
                while (csv.Read())
                {
                    var report = csv.GetRecord<Report>();
                    report.ReportId = Guid.NewGuid().ToString();
                    foreach (var column in csv.Context.HeaderRecord)
                    {
                        if (column == "Province/State" || column == "Country/Region" || column == "Lat" ||
                            column == "Long")
                        {
                            continue;
                        }

                        var dailyConfirmedReport = new DailyConfirmedReport()
                        {
                            DailyConfirmedReportId = Guid.NewGuid().ToString(),
                            Date = DateTime.Parse(column),
                            Report = report,
                            Value = long.Parse(csv.GetField(column))
                        };

                        report.DailyConfirmedReports.Add(dailyConfirmedReport);
                    }
                    reports.Add(report);
                }
            }
            return reports;
        }

        public IList<Report> GetRecoveredReports()
        {
            var recoveredReportsFilePath = GetRecoveredReportFilePath();
            var reports = new List<Report>();
            using (TextReader reader = File.OpenText(recoveredReportsFilePath))
            {
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.HeaderValidated = null;
                while (csv.Read())
                {
                    var report = csv.GetRecord<Report>();
                    report.ReportId = Guid.NewGuid().ToString();
                    foreach (var column in csv.Context.HeaderRecord)
                    {
                        if (column == "Province/State" || column == "Country/Region" || column == "Lat" ||
                            column == "Long")
                        {
                            continue;
                        }

                        var dailyRecoveredReport = new DailyRecoveredReport()
                        {
                            DailyRecoveredReportId = Guid.NewGuid().ToString(),
                            Date = DateTime.Parse(column),
                            Report = report,
                            Value = long.Parse(csv.GetField(column))
                        };

                        report.DailyRecoveredReports.Add(dailyRecoveredReport);
                    }
                    reports.Add(report);
                }
            }

            return reports;
        }

        public IList<Report> GetDeathsReports()
        {
            var deathsReportsFilePath = GetDeathsReportFilePath();
            var reports = new List<Report>();
            using (TextReader reader = File.OpenText(deathsReportsFilePath))
            {
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.HeaderValidated = null;
                while (csv.Read())
                {
                    var report = csv.GetRecord<Report>();
                    report.ReportId = Guid.NewGuid().ToString();
                    foreach (var column in csv.Context.HeaderRecord)
                    {
                        if (column == "Province/State" || column == "Country/Region" || column == "Lat" ||
                            column == "Long")
                        {
                            continue;
                        }

                        var dailyDeathsReport = new DailyDeathsReport()
                        {
                            DailyDeathsReportId = Guid.NewGuid().ToString(),
                            Date = DateTime.Parse(column),
                            Report = report,
                            Value = long.Parse(csv.GetField(column))
                        };

                        report.DailyDeathsReports.Add(dailyDeathsReport);
                    }
                    reports.Add(report);
                }
            }

            return reports;
        }
    }

    public interface IReportParser
    {
        string GetConfirmedReportFilePath();
        string GetRecoveredReportFilePath();
        string GetDeathsReportFilePath();
        IList<Report> GetConfirmedReports();
        IList<Report> GetRecoveredReports();
        IList<Report> GetDeathsReports();
    }
}
