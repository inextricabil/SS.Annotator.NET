using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using RTCoViD.Models;

namespace RTCoViD.Services
{
    public class TweetParser : ITweetParser
    {
        public IEnumerable<string> GetAllFilesPath()
        {
            var tweetsFilesFolder = "Data" + Path.DirectorySeparatorChar + "tweets";
            var tweetsFilesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), tweetsFilesFolder);
            var tweetFiles = Directory.EnumerateFiles(tweetsFilesFolderPath, "*.csv*", SearchOption.AllDirectories);
            return tweetFiles;
        }

        public List<Tweet> GetTweets()
        {
            var tweetFilesPath = GetAllFilesPath();
            var tweets = new List<Tweet>();
            foreach (var tweetFilePath in tweetFilesPath)
            {
                using (TextReader reader = File.OpenText(tweetFilePath))
                {
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    csv.Configuration.Delimiter = ",";
                    csv.Configuration.MissingFieldFound = null;
                    csv.Configuration.HeaderValidated = null;
                    while (csv.Read())
                    {
                        var tweet = csv.GetRecord<Tweet>();
                        tweet.TweetId = Guid.NewGuid().ToString();
                        tweets.Add(tweet);
                    }
                }
            }
            return tweets;
        }
    }

    public interface ITweetParser
    {
        IEnumerable<string> GetAllFilesPath();
        List<Tweet> GetTweets();
    }
}
