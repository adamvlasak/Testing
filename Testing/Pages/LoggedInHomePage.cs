using OpenQA.Selenium;

namespace Testing.Pages
{
    public class LoggedInHomePage : BasePage
    {
        public IWebElement LessonTitle => _wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));
        public IWebElement UserMenu => _wait.Until(driver => driver.FindElement(By.CssSelector("button#user-menu")));
        public IWebElement LogoutLink => _wait.Until(driver => driver.FindElement(By.LinkText("Logout")));

        public LoggedInHomePage(IWebDriver driver) : base(driver)
        {
        }

        public WebGoatLoginPage Logout()
        {
            UserMenu.Click();
            LogoutLink.Click();
            return new WebGoatLoginPage(_driver);
        }
    }
}