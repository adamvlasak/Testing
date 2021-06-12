using Framework.Components;
using Framework.Core;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public class LessonPage : BasePage
    {
        public UserMenu UserMenu => new(By.CssSelector("div.user-nav div.dropdown"), WebDriver);
        public WebElement LessonTitle => new(By.CssSelector("h1#lesson-title"), WebDriver);
        public WebElement LessonProgressStatus => new(By.CssSelector("div#lesson-progress"), WebDriver);
        public LessonMenu LessonMenu => new(By.CssSelector("div#menu-container ul.nano-content"), WebDriver);

        public LessonPage(IWebDriver webDriver, Uri url) : base(webDriver, url)
        {
        }

        /// <summary>
        /// Opens user menu and clicks on logout link.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Opens user menu and clisks on show developer options link.
        /// In the box with cookies 2 links will apperar.
        /// It will click on enable label debugging link.
        /// </summary>
        public void EnableLabelDebugging()
        {
            UserMenu.EnableLabelDebugging();
        }
    }
}
