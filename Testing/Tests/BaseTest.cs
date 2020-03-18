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
        private readonly Uri hubAddress = new Uri("http://localhost:4444/wd/hub");

        protected IWebDriver WebDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            WebDriver = new RemoteWebDriver(hubAddress, options);
            WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            WebDriver.Screenshot();
            WebDriver.Manage().Cookies.DeleteAllCookies();
            WebDriver.Quit();
        }
    }
}