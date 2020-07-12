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

        protected WebDriverWait CreateWebDriverWait(uint timeout = defaultTimeout)
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

        public void GoToUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void Visit()
        {
            GoToUrl(BaseUrl.ToString());
        }

        public void VisitPath(string path)
        {
            GoToUrl($"{BaseUrl}{path}");
        }
    }
}