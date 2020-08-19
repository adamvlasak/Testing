using System;
using WebGoat.Framework;

namespace WebGoat.Data
{
    public class Link
    {
        public string Title { get; set; }
        public string Path => $"/start.mvc#attack/{Id}/{Score}";
        public Uri Domain => new Uri($"{Configuration.ApplicationUrl}");
        public Uri Url => new Uri($"{Domain}{Path}");
        public string Parent { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
    }
}
