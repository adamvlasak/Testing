using OpenQA.Selenium;
using WebGoat.Extensions;

namespace WebGoat.Pages
{
    public sealed class LoggedInPage : BasePage
    {
        public IWebElement LessonTitle => WebDriver.FindElementWithWait(By.CssSelector("h1#lesson-title"));
        public IWebElement UserMenu => WebDriver.FindElementWithWait(By.CssSelector("button#user-menu"));
        public IWebElement LogoutLink => WebDriver.FindElementWithWait(By.LinkText("Logout"));
        public IWebElement ShowDeveloperOptionsLink => WebDriver.FindElementWithWait(By.LinkText("Show developer controls"));
        public IWebElement DeveloperControlContainer => WebDriver.FindElementWithWait(By.CssSelector("div#developer-control-container"));
        public IWebElement EnableLabelDebuggingLink => WebDriver.FindElementWithWait(By.LinkText("Enable label debugging"));
        public IWebElement DisableabelDebuggingLink => WebDriver.FindElementWithWait(By.LinkText("Disable label debugging"));
        public IWebElement LessonProgressStatus => WebDriver.FindElementWithWait(By.CssSelector("div#lesson-progress"));

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
