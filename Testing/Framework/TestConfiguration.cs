using System;

namespace Testing.Framework
{
    public class TestConfiguration
    {
        public Browser Browser { get; set; }
        public Uri SeleniumHubUrl { get; set; }
        public string ScreenshotPath { get; set; }
        public WindowSize WindowSize { get; set; }
        public string WindowSizeBrowserOption
        {
            get
            {
                return WindowSize switch
                {
                    WindowSize.FullScreen => Browser == Browser.ChromeDriver ? "--start-maximized" : "--window-size=1920,1080",
                    WindowSize.Mobile => "--window-size=372,900",
                    _ => throw new ArgumentException("Unsupported window size"),
                };
            }
        }

        public Uri ApplicationUrl { get; internal set; }
    }
}