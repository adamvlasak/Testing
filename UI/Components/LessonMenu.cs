using Framework.Components;
using Framework.Extensions;
using OpenQA.Selenium;
using System;
using WebGoat.Core;

namespace WebGoat.Components
{
    public class LessonMenu : BaseComponent
    {
        public LessonMenu(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

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

            return Element.FindElementWithWait(By.PartialLinkText(link.Title));
        }

        public void Open(string text)
        {
            GetElement(text).Click();
        }
    }
}
