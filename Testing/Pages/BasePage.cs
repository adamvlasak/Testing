using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Pages
{
    public class BasePage
    {
        private const int defaultTimeout = 5;

        protected IWebDriver WebDriver { get; private set; }
        protected WebDriverWait Wait { get; set; }
        protected Uri BaseUrl { get; private set; }

        protected WebDriverWait CreateWebDriverWait(UInt32 timeout = defaultTimeout)
        {
            return new WebDriverWait(WebDriver, new TimeSpan(0, 0, (int)timeout));
        }

        public BasePage(Uri baseUrl, IWebDriver driver)
        {
            WebDriver = driver;
            Wait = CreateWebDriverWait();
            BaseUrl = baseUrl;
        }

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver;
            Wait = CreateWebDriverWait();
        }

        public void Visit()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);
        }

        public void VisitUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void VisitPath(string path)
        {
            WebDriver.Navigate().GoToUrl($"{BaseUrl}{path}");
        }
    }
}