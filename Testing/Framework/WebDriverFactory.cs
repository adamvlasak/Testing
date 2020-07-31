using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Framework
{
    /// <summary>
    /// Creates various WebDriver instances
    /// </summary>
    public static class WebDriverFactory
    {
        private const int defaultTimeout = 5;

        /// <summary>
        /// Returns instance of RemoteWebDriver
        /// </summary>
        /// <param name="browser">RemoteFirefox or RemoteChrome</param>
        /// <param name="hubAddress">Selenium Hub URL</param>
        /// <returns></returns>
        public static IWebDriver CreateRemoteWebDriver(Browser browser, Uri hubAddress)
        {
            switch (browser)
            {
                case Browser.RemoteFirefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(hubAddress, firefoxOptions);

                case Browser.RemoteChrome:
                    ChromeOptions chromeOptions = new ChromeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(hubAddress, chromeOptions);

                default:
                    throw new ArgumentException("Unsupported browser.");
            }
        }

        /// <summary>
        /// Returns instance of ChromeDriver
        /// </summary>
        /// <returns></returns>
        public static IWebDriver CreateChromeDriver()
        {
            return new ChromeDriver();
        }

        /// <summary>
        /// Creates instance of WebDriverWait with <paramref name="timeout"/>
        /// </summary>
        /// <param name="webDriver">IWebDriver instance</param>
        /// <param name="timeout">Timeout in seconds</param>
        /// <returns></returns>
        public static WebDriverWait CreateWebDriverWait(IWebDriver webDriver, uint timeout = defaultTimeout)
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(timeout));
        }
    }
}
