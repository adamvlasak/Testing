using Framework.Components;
using OpenQA.Selenium;

namespace UI.Components
{
    public class TopNavigation : BaseComponent
    {
        private UserMenu UserMenu => new(By.CssSelector("div.dropdown"), WebDriver, Element);

        private WebElement Info => new(By.CssSelector("button#about-button"), WebDriver, Element);

        private WebElement ContactUs => new(By.CssSelector("a[href='mailto:webgoat@owasp.org?Subject=Webgoat%20feedback']"), WebDriver, Element);



        public TopNavigation(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        private void WaitForPopUpMenu()
        {
            Wait.Until(d => d.FindElement(By.CssSelector("ul.dropdown-menu")).Displayed);
        }

        public override void Click()
        {
            UserMenu.Click();
            WaitForPopUpMenu();
        }

        public void EnableLabelDebugging()
        {
            UserMenu.EnableLabelDebugging();
        }

        public void DisableLabelDebugging()
        {
            UserMenu.DisableLabelDebugging();
        }

        public void ShowAboutDialog()
        {
            Info.Click();
        }

        public void Logout()
        {
            UserMenu.Logout();
        }
    }
}
