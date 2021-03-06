using OpenQA.Selenium;
using System.Collections.Generic;

namespace Framework.Components
{
    public class Table : BaseComponent
    {
        public IEnumerable<IWebElement> Rows => Element.FindElements(By.TagName("tr"));

        public Table(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        public Table(By locator, IWebDriver webDriver, ISearchContext context) : base(locator, webDriver, context)
        {
        }
    }
}
