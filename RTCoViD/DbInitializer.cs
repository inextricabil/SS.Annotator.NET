using RTCoViD.Data;
using RTCoViD.Services;
using System.Linq;

namespace RTCoViD
{
    public class DbInitializer
    {
        public static void Seed(RTCoViDContext context, ITweetParser tweetParser)
        {
            if (!context.Tweet.Any())
            {
                var tweets = tweetParser.GetTweets();
                context.Tweet.AddRange(tweets);
            }
        }
    }
}
