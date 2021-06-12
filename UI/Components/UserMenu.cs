using Framework.Components;
using OpenQA.Selenium;
using System.Threading;

namespace UI.Components
{
    public class UserMenu : BaseComponent
    {
        private WebElement Toggle => new(By.CssSelector("button#user-menu"), WebDriver, Element);

        private WebElement LogoutItem => new(By.CssSelector("ul.dropdown-menu li:nth-child(1) a"), WebDriver, Element);

        private WebElement ShowDeveloperOptionsItem => new(By.LinkText("Show developer controls"), WebDriver, Element);

        private WebElement EnableLabelDebuggingItem => new(By.LinkText("Enable label debugging"), WebDriver, Element);

        private WebElement DisableabelDebuggingItem => new(By.LinkText("Disable label debugging"), WebDriver, Element);

        public UserMenu(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        public override void Click()
        {
            Toggle.Click();
            Thread.Sleep(200);
        }

        public void EnableLabelDebugging()
        {
            Click();
            ShowDeveloperOptionsItem.Click();
            EnableLabelDebuggingItem.Click();
            Click();
        }

        public void Logout()
        {
            Click();
            LogoutItem.Click();
        }
    }
}
