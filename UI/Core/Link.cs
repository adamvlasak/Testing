using Framework.Core;
using System;

namespace UI.Core
{
    public class Link
    {
        public string Title { get; set; }
        public string Path => $"/start.mvc#attack/{Id}/{Score}";
        public static Uri Host => new($"{Configuration.ApplicationUrl}");
        public Uri Url => new($"{Host}{Path}");
        public string Parent { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }
    }
}
