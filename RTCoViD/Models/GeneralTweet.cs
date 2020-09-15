using System;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RTCoViD.Models
{
    public class GeneralTweet
    {
        [Key]
        public string TweetId { get; set; }
        [Name("Created At")]
        public string CreatedAt { get; set; }
        [Name("Text")]
        public string Text { get; set; }
    }
}
