using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace Testing.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        private readonly Uri hubAddress = new Uri("http://localhost:4444/wd/hub");

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            driver = new RemoteWebDriver(hubAddress, options);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Quit();
        }
    }
}