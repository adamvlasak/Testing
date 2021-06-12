using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Core
{
    /// <summary>
    /// Creates various WebDriver instances and WebDriverWait
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Returns instance of RemoteWebDriver
        /// </summary>
        /// <returns>IWebDriver</returns>
        private static IWebDriver RemoteWebDriver()
        {
            switch (Configuration.Browser)
            {
                case Browser.RemoteFirefox:
                    var firefoxOptions = Configuration.DefaultFirefoxOptions;
                    return new RemoteWebDriver(Configuration.SeleniumHubUrl, firefoxOptions);

                case Browser.RemoteChrome:
                    var chromeOptions = Configuration.DefaultChromeOptions;
                    chromeOptions.AddArgument(Configuration.ChromeWindowOption);
                    return new RemoteWebDriver(Configuration.SeleniumHubUrl, chromeOptions);

                default:
                    throw new ArgumentException("Unsupported browser.");
            }
        }

        /// <summary>
        /// Returns instance of ChromeDriver
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver ChromeDriver()
        {
            var options = Configuration.DefaultChromeOptions;
            options.AddArgument(Configuration.ChromeWindowOption);
            return new ChromeDriver(options);
        }

        /// <summary>
        /// Returns instance of GeckoDriver (Firefox)
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver FirefoxDriver()
        {
            var options = Configuration.DefaultFirefoxOptions;
            return new FirefoxDriver(options);
        }

        /// <summary>
        /// Returns instance of EdgeDriver
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        private static IWebDriver EdgeDriver()
        {
            var options = Configuration.DefaultEdgeOptions;
            return new EdgeDriver();
        }

        /// <summary>
        /// Creates IWebDriver instance based on given configuration
        /// </summary>
        /// <returns>IWebDriver instance</returns>
        public static IWebDriver CreateWebDriver()
        {
            switch (Configuration.Browser)
            {
                case Browser.ChromeDriver:
                    return ChromeDriver();

                case Browser.FirefoxDriver:
                    return FirefoxDriver();

                case Browser.EdgeDriver:
                    return EdgeDriver();

                case Browser.RemoteChrome:
                    return RemoteWebDriver();

                default:
                    throw new Exception($"Unable to use browser: {Configuration.Browser}.");
            }
        }

        /// <summary>
        /// Creates instance of WebDriverWait with <paramref name="timeout"/>
        /// </summary>
        /// <param name="webDriver">IWebDriver instance</param>
        /// <param name="timeout">Timeout in seconds</param>
        /// <returns>WebDriverWait instance</returns>
        public static WebDriverWait CreateWebDriverWait(IWebDriver webDriver, uint timeout = Configuration.DefaultTimeout)
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
        }
    }
}
