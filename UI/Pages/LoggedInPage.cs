using Framework.Core;
using Framework.Extensions;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public sealed class LoggedInPage : BasePage
    {
        public IWebElement LessonTitle => WebDriver.FindElementWithWait(By.CssSelector("h1#lesson-title"));
        public IWebElement LessonProgressStatus => WebDriver.FindElementWithWait(By.CssSelector("div#lesson-progress"));

        private UserMenu _userMenu;
        public UserMenu UserMenu => _userMenu ??= WebDriver.FindElementWithWait<UserMenu>(By.CssSelector("div.user-nav div.dropdown"));

        public LessonMenu LessonMenu => WebDriver.FindElementWithWait<LessonMenu>(By.CssSelector("div#menu-container ul.nano-content"));

        public LoggedInPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public LogoutPage Logout()
        {
            UserMenu.Logout();
            return new LogoutPage(WebDriver, SiteMap.LogoutPageUrl);
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
