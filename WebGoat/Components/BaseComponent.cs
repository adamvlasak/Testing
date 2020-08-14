using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace WebGoat.Components
{
    public abstract class BaseComponent : BaseObject, ISearchContext
    {
        protected IWebElement Element { get; }

        protected BaseComponent(IWebDriver webDriver, IWebElement element) : base(webDriver)
        {
            Element = element;
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
