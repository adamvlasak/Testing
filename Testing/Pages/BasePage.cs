using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Pages
{
    public class BasePage
    {
        private const int waitTime = 5;

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