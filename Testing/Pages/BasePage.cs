using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Pages
{
    public class BasePage
    {
        private const int waitTime = 5;
        protected IWebDriver WebDriver { get; set; }
        protected WebDriverWait Wait { get; set; }

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver;
            Wait = new WebDriverWait(WebDriver, new TimeSpan(0, 0, waitTime));
        }
    }
}