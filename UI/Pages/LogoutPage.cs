using Framework.Core;
using Framework.Extensions;
using OpenQA.Selenium;
using System;

namespace WebGoat.Pages
{
    public class LogoutPage : BasePage
    {
        public IWebElement AlertSuccess => WebDriver.FindElementWithWait(By.CssSelector("div.alert-success"));
        public IWebElement LoginLink => WebDriver.FindElementWithWait(By.CssSelector("h4 a"));

        public LogoutPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }
    }
}