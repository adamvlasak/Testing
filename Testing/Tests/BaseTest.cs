using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace Testing.Tests
{
    public enum Browser
    {
        Chrome,
        ChromeDriver,
        Firefox
    }

    [TestFixture]
    public class BaseTest
    {
        private readonly Browser browser = Browser.ChromeDriver;
        private readonly Uri hubAddress = new Uri("http://localhost:4444/wd/hub");

        protected IWebDriver WebDriver { get; private set; }

        private IWebDriver CreateWebDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(hubAddress, firefoxOptions);

                case Browser.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Default
                    };
                    return new RemoteWebDriver(hubAddress, chromeOptions);
                case Browser.ChromeDriver:
                    return new ChromeDriver();
                default:
                    throw new InvalidProgramException("Unsupported browser.");

            }
        }

        [OneTimeSetUp]
        public void Setup()
        {
            WebDriver = CreateWebDriver(browser);
            WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                WebDriver.Screenshot();
            }

            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Close();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriver?.Quit();
        }
    }
}