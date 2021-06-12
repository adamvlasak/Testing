using Framework.Components;
using Framework.Core;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public class BaseLessonPage : BasePage
    {
        public UserMenu UserMenu => new(By.CssSelector("div.user-nav div.dropdown"), WebDriver);
        public WebElement LessonTitle => new(By.CssSelector("h1#lesson-title"), WebDriver);
        public WebElement LessonProgressStatus => new(By.CssSelector("div#lesson-progress"), WebDriver);
        public LessonMenu LessonMenu => new(By.CssSelector("div#menu-container ul.nano-content"), WebDriver);

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
