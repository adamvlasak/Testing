using Framework.Components;
using OpenQA.Selenium;

namespace UI.Components
{
    public class TopNavigation : BaseComponent
    {
        private UserMenu UserMenu => new(By.CssSelector("div.dropdown"), WebDriver, Element);

        private WebElement Info => new(By.CssSelector("button#about-button"), WebDriver, Element);

        public TopNavigation(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
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
