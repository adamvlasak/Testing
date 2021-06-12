using Framework.Extensions;
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Framework.Components
{
    public abstract class BaseComponent : BaseObject, ISearchContext
    {
        protected BaseComponent(By locator, IWebDriver webDriver) : base(webDriver)
        {
            Locator = locator;
            _context = WebDriver;
        }

        protected BaseComponent(By locator, IWebDriver webDriver, ISearchContext context) : base(webDriver)
        {
            Locator = locator;
            _context = context;
        }

        protected By Locator { get; }

        private readonly ISearchContext _context;

        protected IWebElement Element => _context.FindElementWithWait(Locator);

        public bool Displayed => Element.Displayed;

        public bool Enabled => Element.Enabled;

        public string Text => Element.Text;

        public bool Present => _context.FindElements(Locator).Count > 0;

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }

        public virtual void Click()
        {
            Element.Click();
        }

        public IWebElement FindElement(By by)
        {
            return _context.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return _context.FindElements(by);
        }
    }
}
