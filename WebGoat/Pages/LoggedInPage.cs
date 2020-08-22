using OpenQA.Selenium;
using System;
using WebGoat.Components;
using WebGoat.Extensions;
using WebGoat.Framework;

namespace WebGoat.Pages
{
    public sealed class LoggedInPage : BasePage
    {
        public IWebElement LessonTitle => WebDriver.FindElementWithWait(By.CssSelector("h1#lesson-title"));
        public IWebElement LessonProgressStatus => WebDriver.FindElementWithWait(By.CssSelector("div#lesson-progress"));

        private UserMenu _userMenu;
        public UserMenu UserMenu => _userMenu != null ? _userMenu : _userMenu = WebDriver.FindElementWithWait<UserMenu>(By.CssSelector("div.user-nav div.dropdown"));

        public LessonMenu LessonMenu => WebDriver.FindElementWithWait<LessonMenu>(By.CssSelector("div#menu-container ul.nano-content"));

        public LoggedInPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoggedInPage(IWebDriver webDriver, System.Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public LoginPage Logout()
        {
            UserMenu.Logout();
            return new LoginPage(WebDriver);
        }

        public void EnableLabelDebugging()
        {
            UserMenu.EnableLabelDebugging();
        }

        public void OpenLesson(string lessonTitle)
        {
            LessonMenu.Open(lessonTitle);
        }
    }
}
