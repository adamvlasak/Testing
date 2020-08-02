using NUnit.Framework;
using OpenQA.Selenium;
using System;
using WebGoat.Framework;

namespace WebGoat.Tests
{
    public class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        protected Configuration Configuration => new Configuration
        {
            Browser = Browser.RemoteChrome,
            SeleniumHubUrl = new Uri("http://localhost:4444/wd/hub"),
            ApplicationUrl = new Uri("http://webapp:8080/WebGoat"),
            ScreenshotPath = @"c:\tmp\screenshots",
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
                var screenshot = WebDriver.Screenshot(Configuration.ScreenshotPath, TestContext.CurrentContext.Test.ClassName, TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshot);
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