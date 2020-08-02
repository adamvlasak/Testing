using OpenQA.Selenium;

namespace WebGoat.Pages
{
    public sealed class LoggedInPage : BasePage
    {
        public IWebElement LessonTitle => Wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));
        public IWebElement UserMenu => Wait.Until(driver => driver.FindElement(By.CssSelector("button#user-menu")));
        public IWebElement LogoutLink => Wait.Until(driver => driver.FindElement(By.LinkText("Logout")));
        public IWebElement ShowDeveloperOptionsLink => Wait.Until(driver => driver.FindElement(By.LinkText("Show developer controls")));
        public IWebElement DeveloperControlContainer => Wait.Until(driver => driver.FindElement(By.CssSelector("div#developer-control-container")));
        public IWebElement EnableLabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Enable label debugging")));
        public IWebElement DisableabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Disable label debugging")));
        public IWebElement LessonProgressStatus => Wait.Until(driver => driver.FindElement(By.CssSelector("div#lesson-progress")));

        public LoggedInPage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public LoggedInPage(IWebDriver driver) : base(driver)
        {
        }

        public void WaitForReady()
        {
            WebDriver.WaitForReady(Wait, FrontendFramework.vanilla);
        }

        public LoginPage Logout()
        {
            UserMenu.Click();
            LogoutLink.Click();
            return new LoginPage(WebDriver);
        }

        public void EnableLabelDebugging()
        {
            UserMenu.Click();
            ShowDeveloperOptionsLink.Click();
            EnableLabelDebuggingLink.Click();
        }
    }
}