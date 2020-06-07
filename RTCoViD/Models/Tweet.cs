using System;
using CsvHelper.Configuration.Attributes;

namespace RTCoViD.Models
{
    public class Tweet
    {
        [Name("tweet_id")]
        public string TweetId { get; set; }
        [Name("created_at")]
        public DateTime CreatedAt { get; set; }
        [Name("loc")]
        public string Location { get; set; }
        [Name("text")]
        public string Text { get; set; }
        [Name("user_id")]
        public string UserId { get;set; }
        [Name("verified")]
        public int Verified { get; set; }
    }
}
