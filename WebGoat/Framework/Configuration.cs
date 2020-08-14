using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace WebGoat.Framework
{
    /// <summary>
    /// Holds current configuration of Application under Test and infrastructure
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Browser to test with
        /// </summary>
        public Browser Browser { get; set; }

        /// <summary>
        /// URL of Selenium Grid
        /// </summary>
        public Uri SeleniumHubUrl { get; set; }

        /// <summary>
        /// URL of Application under test
        /// </summary>
        public Uri ApplicationUrl { get; set; }

        /// <summary>
        /// Path to directory in which screen shots will be saved
        /// </summary>
        public string ScreenshotPath { get; set; }

        /// <summary>
        /// Window size of the browser
        /// </summary>
        public WindowSize WindowSize { get; set; }

        /// <summary>
        /// Default timeout used for Explicit Waiting
        /// </summary>
        public const uint DefaultTimeout = 5;

        /// <summary>
        /// Based on other properties returns correct window size argument for WebDriver
        /// </summary>
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

        /// <summary>
        /// TODO: use app.config or configuration.json
        /// </summary>
        /// <returns></returns>
        public static Configuration Create()
        {
            return new Configuration
            {
                Browser = Browser.ChromeDriver,
                SeleniumHubUrl = new Uri("http://localhost:4444/wd/hub"),
                ApplicationUrl = new Uri("http://localhost:8080/WebGoat"),
                ScreenshotPath = @"c:\tmp\screenshots",
                WindowSize = WindowSize.FullScreen
            };
        }
    }
}
