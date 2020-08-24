using Framework.Components;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Core
{
    public abstract class BasePage : BaseObject
    {
        public Uri Url { get; }

        public string Path => Url.PathAndQuery;

        protected BasePage(IWebDriver webDriver, Uri url) : base(webDriver)
        {
            Url = url;
        }

        /// <summary>
        /// Navigates to page URL.
        /// </summary>
        public virtual void Visit()
        {
            VisitUrl(Url);
        }

        /// <summary>
        /// Navigates to any URL.
        /// </summary>
        /// <param name="url"></param>
        public void VisitUrl(Uri url)
        {
            WebDriver.Navigate().GoToUrl(url.ToString());
            Assert.That(WebDriver.Url, Is.EqualTo(url));
        }
    }
}
