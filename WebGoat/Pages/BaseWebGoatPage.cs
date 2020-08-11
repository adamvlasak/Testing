using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebGoat.Pages
{
    public class BaseWebGoatPage : BasePage
    {
        public BaseWebGoatPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public BaseWebGoatPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public override void Visit()
        {
            base.Visit();
            WebDriver.WaitForReady(Wait);
        }
    }
}
