using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace Framework.Core
{
    /// <summary>
    /// Holds current configuration of Application under Test and infrastructure
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Browser to test with
        /// </summary>
        public static Browser Browser { get; set; } = Browser.RemoteChrome;

        /// <summary>
        /// URL of Selenium Grid
        /// </summary>
        public static Uri SeleniumHubUrl { get; set; } = new Uri("http://localhost:4444/wd/hub");

        /// <summary>
        /// URL of Application under test
        /// </summary>
        public static Uri ApplicationUrl { get; set; } = new Uri("http://webgoat:8080/WebGoat");

        /// <summary>
        /// Path to directory in which screen shots will be saved
        /// </summary>
        public static string ScreenshotPath { get; set; } = ScreenshotPath = @"c:\tmp\screenshots";

        /// <summary>
        /// Window size of the browser
        /// </summary>
        public static WindowSize WindowSize { get; set; } = WindowSize.FullScreen;

        /// <summary>
        /// Default timeout used for Explicit Waiting
        /// </summary>
        public const uint DefaultTimeout = 5;

        /// <summary>
        /// Based on other properties returns correct window size argument for WebDriver
        /// </summary>
        public static string WindowSizeBrowserOption
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

        /// <summary>
        /// Returns default ChromeOptions
        /// </summary>
        public static ChromeOptions DefaultChromeOptions => new ChromeOptions
        {
            PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Default
        };

        /// <summary>
        /// Returns default FirefoxOptions
        /// </summary>
        public static FirefoxOptions DefaultFirefoxOptions => new FirefoxOptions
        {
            PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Default
        };

        /// <summary>
        /// Returns default EdgeOptions
        /// </summary>
        public static EdgeOptions DefaultEdgeOptions => new EdgeOptions
        {
            PageLoadStrategy = OpenQA.Selenium.PageLoadStrategy.Default
        };
    }
}
