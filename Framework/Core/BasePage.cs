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
                UrlChanging?.Invoke(this, new EventArgs<Uri>(value));
                _url = value;
                UrlChanged?.Invoke(this, new EventArgs<Uri>(_url));
            }
        }

        private Uri _url;

        public string Path => Url.PathAndQuery;

        public EventHandler<EventArgs<Uri>> UrlChanging;
        public EventHandler<EventArgs<Uri>> UrlChanged;

        public EventHandler<EventArgs<Uri>> Visiting;
        public EventHandler<EventArgs<Uri>> Visited;

        protected BasePage(IWebDriver webDriver, Uri url) : base(webDriver)
        {
            UrlChanging += (sender, args) => TestContext.Progress.WriteLine($"{DateTime.Now} ~ {this.ToString()} ~ Url property changing value to: {args.Value}");
            UrlChanged += (sender, args) => TestContext.Progress.WriteLine($"{DateTime.Now} ~ {this.ToString()} ~ Url property has changed value to: {args.Value}");
            Visiting += (sender, args) => TestContext.Progress.WriteLine($"{DateTime.Now} ~ {this.ToString()} ~ WebDriver Url before visiting: {args.Value}");
            Visited += (sender, args) => TestContext.Progress.WriteLine($"{DateTime.Now} ~ {this.ToString()} ~ WebDriver has visited URL to: {args.Value}");
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
            Visiting?.Invoke(this, new EventArgs<Uri>(new Uri(WebDriver.Url)));
            WebDriver.Navigate().GoToUrl(url.ToString());
            Visited?.Invoke(this, new EventArgs<Uri>(new Uri(WebDriver.Url)));
            Assert.That(WebDriver.Url, Is.EqualTo(url));
        }
    }
}
