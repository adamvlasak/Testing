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
                    WindowSize.FullScreen => "--maximized",
                    WindowSize.Mobile => "--window-size=372,900",
                    _ => throw new ArgumentException("Unsupported window size"),
                };
            }
        }
    }
}