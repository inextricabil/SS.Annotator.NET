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
                var reports = reportParser.GetReports();
            }
        }
    }
}
