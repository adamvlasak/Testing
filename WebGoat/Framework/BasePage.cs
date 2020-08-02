using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WebGoat.Framework;

namespace WebGoat.Pages
{
    public class BasePage
    {
        protected IWebDriver WebDriver { get; private set; }
        protected WebDriverWait Wait { get; set; }
        protected Uri BaseUrl { get; private set; }

        public BasePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
            Wait = Factory.CreateWebDriverWait(WebDriver);
        }

        public BasePage(IWebDriver webDriver, Uri baseUrl)
        {
            WebDriver = webDriver;
            Wait = Factory.CreateWebDriverWait(WebDriver);
            BaseUrl = baseUrl;
        }

        public BasePage(IWebDriver webDriver, WebDriverWait wait, Uri baseUrl)
        {
            WebDriver = webDriver;
            Wait = wait;
            BaseUrl = baseUrl;
        }

        public void GoToUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public virtual void Visit()
        {
            GoToUrl(BaseUrl.ToString());
        }

        public void VisitPath(string path)
        {
            GoToUrl($"{BaseUrl}{path}");
        }
    }
}
