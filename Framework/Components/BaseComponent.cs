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
        }

        protected By Locator { get; }

        protected IWebElement Element => WebDriver.FindElementWithWait(Locator);

        public bool Displayed => Element.Displayed;

        public bool Enabled => Element.Enabled;

        public string Text => Element.Text;

        public bool Present => WebDriver.FindElements(Locator).Count > 0;

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
            return Element.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Element.FindElements(by);
        }
    }
}
