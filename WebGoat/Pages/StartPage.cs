using OpenQA.Selenium;
using System;
using WebGoat.Framework;

namespace WebGoat.Pages
{
    public sealed class StartPage : BasePage
    {
        public StartPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public StartPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }
    }
}
