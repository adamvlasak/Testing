using Framework.Components;
using OpenQA.Selenium;
using System.Threading;

namespace UI.Components
{
    class UserMenu : BaseComponent
    {
        public UserMenu(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        public UserMenu(By locator, IWebDriver webDriver, ISearchContext context) : base(locator, webDriver, context)
        {
        }

        private WebElement ShowDeveloperOptionsItem => new(By.LinkText("Show developer controls"), WebDriver, Element);

        private WebElement HideDeveloperOptionsItem => new(By.LinkText("Hide developer controls"), WebDriver, Element);

        private WebElement EnableLabelDebuggingItem => new(By.LinkText("Enable label debugging"), WebDriver);

        private WebElement DisableLabelDebuggingItem => new(By.LinkText("Disable label debugging"), WebDriver);

        private WebElement LogoutItem => new(By.CssSelector("li:nth-child(1) a"), WebDriver, Element);

        public override void Click()
        {
            base.Click();
            Thread.Sleep(250); // intentionally
        }

        public void EnableLabelDebugging()
        {
            Click();
            ShowDeveloperOptionsItem.Click();
            EnableLabelDebuggingItem.Click();
            HideDeveloperOptionsItem.Click();
            Click();
        }

        public void DisableLabelDebugging()
        {
            Click();
            ShowDeveloperOptionsItem.Click();
            DisableLabelDebuggingItem.Click();
            HideDeveloperOptionsItem.Click();
            Click();
        }

        public void Logout()
        {
            Click();
            LogoutItem.Click();
        }
    }
}
