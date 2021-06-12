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
            Clicked += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Clicking on \"{Locator}\""));
            ComponentWaiting += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Waiting for wrapped element \"{Locator}\" in DOM"));
            ElementFinding += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding element(s) \"{Locator}\" in DOM"));
        }

        protected BaseComponent(By locator, IWebDriver webDriver, ISearchContext context) : base(webDriver)
        {
            Locator = locator;
            _context = context;
            Clicked += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Clicking on \"{Locator}\""));
            ComponentWaiting += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Waiting for wrapped element \"{Locator}\" in DOM"));
            ElementFinding += (sender, args) => TestContext.Progress.WriteLine(LogMessage($"Finding element(s) \"{Locator}\" in DOM"));
        }

        protected By Locator { get; }

        private readonly ISearchContext _context;

        protected IWebElement Element
        {
            get
            {
                ComponentWaiting?.Invoke(this, EventArgs.Empty);
                return _context.FindElementWithWait(Locator);
            }
        }

        public bool Displayed => Element.Displayed;

        public bool Enabled => Element.Enabled;

        public string Text => Element.Text;

        public bool Present => _context.FindElements(Locator).Count > 0;

        public EventHandler Clicked;
        public EventHandler ComponentWaiting;
        public EventHandler ElementFinding;

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public virtual void Click()
        {
            Element.Click();
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        public IWebElement FindElement(By by)
        {
            ElementFinding?.Invoke(this, EventArgs.Empty);
            return _context.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            ElementFinding?.Invoke(this, EventArgs.Empty);
            return _context.FindElements(by);
        }
    }
}
