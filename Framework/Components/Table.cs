using OpenQA.Selenium;
using System.Collections.Generic;

namespace Framework.Components
{
    public class Table : BaseComponent
    {
        public IEnumerable<IWebElement> Rows => Element.FindElements(By.TagName("tr"));

        public Table(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }
    }
}
