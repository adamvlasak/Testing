using System;
using OpenQA.Selenium;

namespace WebGoat.Pages
{
    public class StartPage : BaseWebGoatPage
    {
        public StartPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public StartPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }
    }
}