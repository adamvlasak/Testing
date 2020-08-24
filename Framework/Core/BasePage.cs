using Framework.Components;
using OpenQA.Selenium;
using System;

namespace Framework.Core
{
    public abstract class BasePage : BaseObject
    {
        protected Uri BaseUrl { get; }

        protected BasePage(IWebDriver webDriver, Uri baseUrl) : base(webDriver)
        {
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// Navigates to page BaseUrl.
        /// </summary>
        public virtual void Visit()
        {
            VisitUrl(BaseUrl);
        }

        /// <summary>
        /// Navigates to any URL.
        /// </summary>
        /// <param name="url"></param>
        public void VisitUrl(Uri url)
        {
            WebDriver.Navigate().GoToUrl(url.ToString());
        }

        /// <summary>
        /// Navigates to URL path. Uses BaseUrl.
        /// </summary>
        /// <param name="path"></param>
        public void VisitPath(string path)
        {
            VisitUrl(new Uri($"{BaseUrl}{path}"));
        }
    }
}
