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

        public string GetGeneralTweetsFilePath()
        {
            var tweetsFilesFolder = "Data" + Path.DirectorySeparatorChar + "tweets";
            var tweetsFilesFolderPath =
                Path.Combine(Directory.GetCurrentDirectory(), tweetsFilesFolder, "neutraltweets.csv");
            return tweetsFilesFolderPath;
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

        public List<GeneralTweet> GetGeneralTweets()
        {
            var generalTweetsFilePath = GetGeneralTweetsFilePath();
            var generalTweets = new List<GeneralTweet>();
            using (TextReader reader = File.OpenText(generalTweetsFilePath))
            {
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                csv.Configuration.Delimiter = ",";
                csv.Configuration.MissingFieldFound = null;
                csv.Configuration.HeaderValidated = null;
                var randomDateTime = new RandomDateTime();
                while (csv.Read())
                {
                    var tweet = csv.GetRecord<GeneralTweet>();
                    tweet.TweetId = Guid.NewGuid().ToString();
                    tweet.CreatedAt = randomDateTime.Next().ToShortDateString();
                    generalTweets.Add(tweet);
                }
            }

            return generalTweets;
        }
    }



    class RandomDateTime
    {
        DateTime start;
        Random gen;
        int range;

        public RandomDateTime()
        {
            start = new DateTime(2020, 2, 1);
            gen = new Random();
            range = (DateTime.Today - start).Days;
        }

        public DateTime Next()
        {
            return start.AddDays(gen.Next(range)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60))
                .AddSeconds(gen.Next(0, 60));
        }
    }

    public interface ITweetParser
    {
        IEnumerable<string> GetAllFilesPath();
        List<Tweet> GetTweets();
        List<GeneralTweet> GetGeneralTweets();
    }
}
