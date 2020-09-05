using Framework.Components;
using Framework.Extensions;
using OpenQA.Selenium;
using System.Threading;

namespace UI.Components
{
    public class UserMenu : BaseComponent
    {
        private IWebElement Toggle => Element.FindElementWithWait(By.CssSelector("button#user-menu"));

        private IWebElement LogoutItem => Element.FindElementWithWait(By.CssSelector("ul.dropdown-menu li:nth-child(1) a"));

        private IWebElement ShowDeveloperOptionsItem => Element.FindElementWithWait(By.LinkText("Show developer controls"));

        private IWebElement EnableLabelDebuggingItem => WebDriver.FindElementWithWait(By.LinkText("Enable label debugging"));

        private IWebElement DisableabelDebuggingItem => WebDriver.FindElementWithWait(By.LinkText("Disable label debugging"));

        public UserMenu(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

        public void Click()
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
