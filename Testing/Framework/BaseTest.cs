using NUnit.Framework;
using OpenQA.Selenium;
using System;
using Testing.Framework;

namespace Testing.Tests
{
    public class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        protected TestConfiguration Configuration => new TestConfiguration
        {
            Browser = Browser.RemoteChrome,
            SeleniumHubUrl = new Uri("http://localhost:4444/wd/hub"),
            ApplicationUrl = new Uri("http://webapp:8080/WebGoat"),
            ScreenshotPath = @"c:\tmp",
            WindowSize = WindowSize.FullScreen
        };

        [OneTimeSetUp]
        public void Setup()
        {
            WebDriver = Factory.CreateWebDriver(Configuration);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                WebDriver.Screenshot(Configuration.ScreenshotPath, TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName);
            }

            WebDriver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriver?.Quit();
        }
    }
}