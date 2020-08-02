using OpenQA.Selenium;

namespace WebGoat.Pages
{
    public sealed class LoggedInPage : BaseWebGoatPage
    {
        public IWebElement LessonTitle => Wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));
        public IWebElement UserMenu => Wait.Until(driver => driver.FindElement(By.CssSelector("button#user-menu")));
        public IWebElement LogoutLink => Wait.Until(driver => driver.FindElement(By.LinkText("Logout")));
        public IWebElement ShowDeveloperOptionsLink => Wait.Until(driver => driver.FindElement(By.LinkText("Show developer controls")));
        public IWebElement DeveloperControlContainer => Wait.Until(driver => driver.FindElement(By.CssSelector("div#developer-control-container")));
        public IWebElement EnableLabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Enable label debugging")));
        public IWebElement DisableabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Disable label debugging")));
        public IWebElement LessonProgressStatus => Wait.Until(driver => driver.FindElement(By.CssSelector("div#lesson-progress")));

        public LoggedInPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoggedInPage(IWebDriver webDriver, System.Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public LoginPage Logout()
        {
            UserMenu.Click();
            LogoutLink.Click();
            WebDriver.WaitForReady(Wait);
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