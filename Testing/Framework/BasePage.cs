using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Testing.Framework;

namespace Testing.Pages
{
    public class BasePage
    {
        protected IWebDriver WebDriver { get; private set; }
        protected WebDriverWait Wait { get; set; }
        protected Uri BaseUrl { get; private set; }

        public BasePage(Uri baseUrl, IWebDriver driver)
        {
            WebDriver = driver;
            Wait = WebDriverFactory.CreateWebDriverWait(WebDriver);
            BaseUrl = baseUrl;
        }

        public BasePage(IWebDriver driver)
        {
            WebDriver = driver;
            Wait = WebDriverFactory.CreateWebDriverWait(WebDriver);
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