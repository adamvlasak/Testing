using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Linq;
using NUnit.Framework;

namespace Testing.Pages
{
    public class BasePage
    {
        private const int waitTime = 60;

        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, new TimeSpan(0, 0, waitTime));
        }

        public void Screenshot()
        {
            ITakesScreenshot sDriver = (ITakesScreenshot)_driver;
            var screenshot = sDriver.GetScreenshot();
            screenshot.SaveAsFile($"c:\\tmp\\{DateTime.Now.ToFileTime()}.png", ScreenshotImageFormat.Png);
        }
    }
}
