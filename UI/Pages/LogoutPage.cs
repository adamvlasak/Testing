using Framework.Components;
using Framework.Core;
using OpenQA.Selenium;
using System;

namespace UI.Pages
{
    public class LogoutPage : BasePage
    {
        public WebElement AlertSuccess => new(By.CssSelector("div.alert-success"), WebDriver);
        public WebElement LoginLink => new(By.CssSelector("h4 a"), WebDriver);

        public LogoutPage(IWebDriver webDriver, Uri url) : base(webDriver, url)
        {
        }
    }
}
