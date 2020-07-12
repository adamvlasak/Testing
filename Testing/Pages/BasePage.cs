using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Pages
{
    public class BasePage
    {
        private const int waitTime = 5;

        protected IWebDriver WebDriver { get; private set; }
        protected WebDriverWait Wait { get; private set; }
        protected Uri BaseUrl { get; private set; }

        private WebDriverWait CreateWebDriverWait()
        {
            return new WebDriverWait(WebDriver, new TimeSpan(0, 0, waitTime));
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