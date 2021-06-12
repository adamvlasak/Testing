using Framework.Components;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Framework.Core
{
    public abstract class BasePage : BaseObject
    {
        public Uri Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                OnUrlChange?.Invoke(this, new EventArgs<Uri>(_url));
            }
        }

        private Uri _url;

        public string Path => Url.PathAndQuery;
        public EventHandler<EventArgs<Uri>> OnUrlChange;

        protected BasePage(IWebDriver webDriver, Uri url) : base(webDriver)
        {
            OnUrlChange += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Url property has changed value to: {args.Value}"));
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
