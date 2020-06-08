using System.Collections.Generic;
using RTCoViD.Data;
using RTCoViD.Services;
using System.Linq;
using System.Threading.Tasks;
using RTCoViD.Models;

namespace RTCoViD
{
    public class DbInitializer
    {
        public static async Task SeedTweets(RTCoViDContext context, ITweetParser tweetParser)
        {
            if (!context.Tweet.Any())
            {
                var tweets = tweetParser.GetTweets();
                await context.Tweet.AddRangeAsync(tweets);
                await context.SaveChangesAsync();
            }
        }

        public static async Task SeedReports(RTCoViDContext context, IReportParser reportParser)
        {
            if (!context.Reports.Any())
            {
                var confirmedReports = reportParser.GetConfirmedReports();
                var deathsReports = reportParser.GetDeathsReports();
                var recoveredReports = reportParser.GetRecoveredReports();

                var reports = new List<Report>();
                foreach (var confirmedReport in confirmedReports)
                {
                    var deathsReportsToBeMerged = deathsReports.FirstOrDefault(d => d.Country == confirmedReport.Country &&
                                                                          d.Province == confirmedReport.Province &&
                                                                          d.Latitude == confirmedReport.Latitude &&
                                                                          d.Longitude == confirmedReport.Longitude)?.DailyDeathsReports.ToList();
                    confirmedReport.DailyDeathsReports = new List<DailyDeathsReport>();
                    if (deathsReportsToBeMerged != null)
                    {
                        foreach (var deathReport in deathsReportsToBeMerged)
                        {
                            deathReport.Report = confirmedReport;
                            confirmedReport.DailyDeathsReports.Add(deathReport);
                        }
                    }


                    var recoveredReportsToBeMerged = recoveredReports.FirstOrDefault(r => r.Country == confirmedReport.Country &&
                                                                                          r.Province == confirmedReport.Province &&
                                                                                          r.Latitude == confirmedReport.Latitude &&
                                                                                          r.Longitude == confirmedReport.Longitude)?.DailyRecoveredReports;
                    confirmedReport.DailyRecoveredReports = new List<DailyRecoveredReport>();
                    if (recoveredReportsToBeMerged != null)
                    {
                        foreach (var recoveredReport in recoveredReportsToBeMerged)
                        {
                            recoveredReport.Report = confirmedReport;
                        }
                        confirmedReport.DailyRecoveredReports = recoveredReportsToBeMerged;
                    }

                    reports.Add(confirmedReport);
                }

                await context.Reports.AddRangeAsync(reports);
                await context.SaveChangesAsync();
            }
        }
    }
}
