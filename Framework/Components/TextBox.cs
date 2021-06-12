using OpenQA.Selenium;

namespace Framework.Components
{
    public class TextBox : BaseComponent
    {
        public TextBox(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        public TextBox(By locator, IWebDriver webDriver, ISearchContext context) : base(locator, webDriver, context)
        {
        }

        public void SendKeys(string text)
        {
            Element.SendKeys(text);
        }
    }
}
