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

        public BaseWebGoatPage(IWebDriver webDriver, WebDriverWait wait, Uri baseUrl) : base(webDriver, wait, baseUrl)
        {
        }

        public override void Visit()
        {
            base.Visit();
            WebDriver.WaitForReady(Wait);
        }
    }
}