using Framework.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.ObjectModel;

namespace Framework.Components
{
    public abstract class BaseComponent : BaseObject, ISearchContext
    {
        protected BaseComponent(By locator, IWebDriver webDriver) : base(webDriver)
        {
            Locator = locator;
            _context = WebDriver;
            OnClick += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Clicking on \"{Locator}\""));
            OnComponentFindAndWait += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding wrapped element \"{Locator}\" in DOM"));
            OnElementFind += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding element(s) \"{Locator}\" in DOM"));
        }

        protected BaseComponent(By locator, IWebDriver webDriver, ISearchContext context) : base(webDriver)
        {
            Locator = locator;
            _context = context;
            OnClick += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Clicking on \"{Locator}\""));
            OnComponentFindAndWait += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding wrapped element \"{Locator}\" in DOM"));
            OnElementFind += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding element(s) \"{Locator}\" in DOM"));
        }

        protected By Locator { get; }

        private readonly ISearchContext _context;

        protected IWebElement Element
        {
            get
            {
                var el = _context.FindElementWithWait(Locator);
                OnComponentFindAndWait?.Invoke(this, EventArgs.Empty);
                return el;
            }
        }

        public bool Displayed => Element.Displayed;

        public bool Enabled => Element.Enabled;

        public string Text => Element.Text;

        public bool Present => _context.FindElements(Locator).Count > 0;

        public EventHandler OnClick;
        public EventHandler OnComponentFindAndWait;
        public EventHandler OnElementFind;

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public virtual void Click()
        {
            OnClick?.Invoke(this, EventArgs.Empty);
            Element.Click();
        }

        public IWebElement FindElement(By by)
        {
            OnElementFind?.Invoke(this, EventArgs.Empty);
            return _context.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            OnElementFind?.Invoke(this, EventArgs.Empty);
            return _context.FindElements(by);
        }
    }
}
