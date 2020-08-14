using OpenQA.Selenium;
using System;
using WebGoat.Components;

namespace WebGoat.Framework
{
    public class BasePage : BaseObject
    {
        protected Uri BaseUrl { get; private set; }

        public BasePage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public BasePage(IWebDriver webDriver, Uri baseUrl) : base(webDriver)
        {
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
