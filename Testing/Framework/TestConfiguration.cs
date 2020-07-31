using System;

namespace Testing.Framework
{
    public class TestConfiguration
    {
        public Browser Browser { get; set; }
        public Uri SeleniumHubUrl { get; set; }
        public string ScreenshotPath { get; set; }
    }
}