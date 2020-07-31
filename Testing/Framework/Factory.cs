using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Framework
{
    /// <summary>
    /// Creates various WebDriver instances and WebDriverWait
    /// </summary>
    public static class Factory
    {
        private const int defaultTimeout = 5;

        /// <summary>
        /// Returns instance of RemoteWebDriver
        /// </summary>
        /// <param name="browser">RemoteFirefox or RemoteChrome</param>
        /// <param name="hubAddress">Selenium Hub URL</param>
        /// <returns>IWebDriver</returns>
        private static IWebDriver RemoteWebDriver(TestConfiguration configuration)
        {
            switch (configuration.Browser)
            {
                case Browser.RemoteFirefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(configuration.SeleniumHubUrl, firefoxOptions);

                case Browser.RemoteChrome:
                    ChromeOptions chromeOptions = new ChromeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(configuration.SeleniumHubUrl, chromeOptions);

                default:
                    throw new ArgumentException("Unsupported browser.");
            }
        }

        /// <summary>
        /// Returns instance of ChromeDriver
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver ChromeDriver(TestConfiguration configuration)
        {
            var options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Default
            };
            options.AddArgument(configuration.WindowSizeBrowserOption);
            return new ChromeDriver(options);
        }

        /// <summary>
        /// Returns instance of GeckoDriver (Firefox)
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver GeckoDriver()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns instance of EdgeDriver
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver EdgeDriver()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates IWebDriver instance based on given configuration
        /// </summary>
        /// <param name="configuration"></param>
        /// <returns>IWebDriver instance</returns>
        public static IWebDriver CreateWebDriver(TestConfiguration configuration)
        {
            switch(configuration.Browser)
            {
                case Browser.ChromeDriver:
                    return ChromeDriver(configuration);
                case Browser.GeckoDriver:
                    return GeckoDriver();
                case Browser.EdgeDriver:
                    return EdgeDriver();
                case Browser.RemoteChrome:
                case Browser.RemoteFirefox:
                    return RemoteWebDriver(configuration);
                default:
                    throw new Exception("Invalid configuration.");
            }
        }

        /// <summary>
        /// Creates instance of WebDriverWait with <paramref name="timeout"/>
        /// </summary>
        /// <param name="webDriver">IWebDriver instance</param>
        /// <param name="timeout">Timeout in seconds</param>
        /// <returns>WebDriverWait instance</returns>
        public static WebDriverWait CreateWebDriverWait(IWebDriver webDriver, uint timeout = defaultTimeout)
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
        }
    }
}
