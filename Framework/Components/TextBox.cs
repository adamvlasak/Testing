using OpenQA.Selenium;

namespace Framework.Components
{
    public class TextBox : BaseComponent
    {
        public TextBox(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }

        public void SendKeys(string text)
        {
            Element.SendKeys(text);
        }
    }
}
