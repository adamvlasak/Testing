using Framework.Core;
using Framework.Extensions;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public class BaseLessonPage : BasePage
    {
        private UserMenu _userMenu;
        public UserMenu UserMenu => _userMenu ??= WebDriver.FindElementWithWait<UserMenu>(By.CssSelector("div.user-nav div.dropdown"));
        public IWebElement LessonTitle => WebDriver.FindElementWithWait(By.CssSelector("h1#lesson-title"));
        public IWebElement LessonProgressStatus => WebDriver.FindElementWithWait(By.CssSelector("div#lesson-progress"));
        public LessonMenu LessonMenu => WebDriver.FindElementWithWait<LessonMenu>(By.CssSelector("div#menu-container ul.nano-content"));
        public BaseLessonPage(IWebDriver webDriver, Uri url) : base(webDriver, url)
        {
        }

        public LogoutPage Logout()
        {
            UserMenu.Logout();
            return new LogoutPage(WebDriver, SiteMap.LogoutPageUrl);
        }

        /// <summary>
        /// Opens lesson by given text name. Uses <paramref name="LessonMenu" /> component
        /// </summary>
        /// <param name="lessonTitle"></param>
        /// <returns></returns>
        public Uri OpenLesson(string lessonTitle)
        {
            return LessonMenu.Open(lessonTitle);
        }
    }
}
