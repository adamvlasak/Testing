using Framework.Components;
using Framework.Extensions;
using OpenQA.Selenium;
using System;
using System.Threading;
using UI.Core;

namespace UI.Components
{
    public class LessonMenu : BaseComponent
    {
        public LessonMenu(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

        /// <summary>
        /// Finds link by text in collection of all lessons,
        /// finds parent link, clicks on it,
        /// waits for the animation to complete
        /// and lastly clicks the link from opened sub menu.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>IWebElement of a link found in sub menu</returns>
        private IWebElement GetElement(string text)
        {
            Link link;
            try
            {
                link = LessonLinks.GetLinkByText(text);
            }
            catch (InvalidOperationException ex)
            {
                throw new ArgumentException($"Unknown link text: {text}", ex);
            }

            var parent = Element.FindElementWithWait(By.PartialLinkText(link.Parent));
            parent.Click();
            Thread.Sleep(200); // animation takes 200 ms according to css
            return Element.FindElementWithWait(By.PartialLinkText(link.Title));
        }

        /// <summary>
        /// Opens lesson by given text name.
        /// </summary>
        /// <param name="text">Lesson to find</param>
        /// <returns>Link's href attribute (full URL).</returns>
        public Uri Open(string text)
        {
            var element = GetElement(text);
            var href = element.GetAttribute("href");
            element.Click();
            Thread.Sleep(200); // animation takes 200 ms according to css
            return new Uri(href);
        }
    }
}
