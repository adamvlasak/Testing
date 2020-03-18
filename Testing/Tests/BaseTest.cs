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
        Firefox
    }

    [TestFixture]
    public class BaseTest
    {
        private readonly Browser browser = Browser.Chrome;
        private readonly Uri hubAddress = new Uri("http://localhost:4444/wd/hub");

        protected IWebDriver WebDriver { get; set; }

        [OneTimeSetUp]
        public void Setup()
        {
            WebDriver = CreateWebDriver(browser);
            WebDriver.Manage().Window.Maximize();
        }

        private IWebDriver CreateWebDriver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Firefox:
                    FirefoxOptions firefoxOptions = new FirefoxOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Normal
                    };
                    return new RemoteWebDriver(hubAddress, firefoxOptions);

                case Browser.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions
                    {
                        PageLoadStrategy = PageLoadStrategy.Normal
                    };
                    return new RemoteWebDriver(hubAddress, chromeOptions);

                default:
                    throw new InvalidProgramException("Unsupported browser.");

            }
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Screenshot();
            WebDriver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriver.Quit();
        }
    }
}