using System;
using OpenQA.Selenium;

namespace UI.Pages
{
    public sealed class Lesson1Page : BaseLessonPage
    {
        public Lesson1Page(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public void EnableLabelDebugging()
        {
            UserMenu.EnableLabelDebugging();
        }
    }
}
