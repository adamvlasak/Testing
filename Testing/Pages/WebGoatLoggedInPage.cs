using OpenQA.Selenium;
using System;

namespace Testing.Pages
{
    public sealed class WebGoatLoggedInPage : BasePage
    {
        public IWebElement LessonTitle => Wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));
        public IWebElement UserMenu => Wait.Until(driver => driver.FindElement(By.CssSelector("button#user-menu")));
        public IWebElement LogoutLink => Wait.Until(driver => driver.FindElement(By.LinkText("Logout")));
        public IWebElement ShowDeveloperOptionsLink => Wait.Until(driver => driver.FindElement(By.LinkText("Show developer controls")));
        public IWebElement DeveloperControlContainer => Wait.Until(driver => driver.FindElement(By.CssSelector("div#developer-control-container")));
        public IWebElement EnableLabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Enable label debugging")));
        public IWebElement DisableabelDebuggingLink => Wait.Until(driver => driver.FindElement(By.LinkText("Disable label debugging")));
        public IWebElement LessonProgressStatus => Wait.Until(driver => driver.FindElement(By.CssSelector("div#lesson-progress")));

        public WebGoatLoggedInPage(IWebDriver driver) : base(driver)
        {
        }

        public WebGoatLoginPage Logout()
        {
            UserMenu.Click();
            LogoutLink.Click();
            return new WebGoatLoginPage(WebDriver);
        }

        public void EnableLabelDebugging()
        {
            UserMenu.Click();
            ShowDeveloperOptionsLink.Click();
            EnableLabelDebuggingLink.Click();
        }
    }
}