using RTCoViD.Data;
using RTCoViD.Services;
using System.Linq;
using System.Threading.Tasks;

namespace RTCoViD
{
    public class DbInitializer
    {
        public static async Task Seed(RTCoViDContext context, ITweetParser tweetParser)
        {
            if (!context.Tweet.Any())
            {
                var tweets = tweetParser.GetTweets();
                await context.Tweet.AddRangeAsync(tweets);
                await context.SaveChangesAsync();
            }
        }
    }
}
