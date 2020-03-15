using OpenQA.Selenium;
using System;

namespace Testing.Pages
{
    public sealed class LoggedInHomePage : BasePage
    {
        public IWebElement LessonTitle => _wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));
        public IWebElement UserMenu => _wait.Until(driver => driver.FindElement(By.CssSelector("button#user-menu")));
        public IWebElement LogoutLink => _wait.Until(driver => driver.FindElement(By.LinkText("Logout")));
        public IWebElement ShowDeveloperOptionsLink => _wait.Until(driver => driver.FindElement(By.LinkText("Show developer controls")));
        public IWebElement DeveloperControlContainer => _wait.Until(driver => driver.FindElement(By.CssSelector("div#developer-control-container")));
        public IWebElement EnableLabelDebuggingLink => _wait.Until(driver => driver.FindElement(By.LinkText("Enable label debugging")));
        public IWebElement DisableabelDebuggingLink => _wait.Until(driver => driver.FindElement(By.LinkText("Disable label debugging")));
        public IWebElement LessonProgressStatus => _wait.Until(driver => driver.FindElement(By.CssSelector("div#lesson-progress")));

        public LoggedInHomePage(IWebDriver driver) : base(driver)
        {
        }

        public WebGoatLoginPage Logout()
        {
            UserMenu.Click();
            LogoutLink.Click();
            return new WebGoatLoginPage(_driver);
        }

        public void EnableLabelDebugging()
        {
            UserMenu.Click();
            ShowDeveloperOptionsLink.Click();
            EnableLabelDebuggingLink.Click();
        }
    }
}