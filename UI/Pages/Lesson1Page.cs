using OpenQA.Selenium;
using System;

namespace UI.Pages
{
    public sealed class Lesson1Page : BaseLessonPage
    {
        public Lesson1Page(IWebDriver webDriver, Uri url) : base(webDriver, url)
        {
        }

        public void EnableLabelDebugging()
        {
            UserMenu.EnableLabelDebugging();
        }
    }
}
