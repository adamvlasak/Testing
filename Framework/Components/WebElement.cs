using OpenQA.Selenium;

namespace Framework.Components
{
    public class WebElement : BaseComponent
    {
        public WebElement(By locator, IWebDriver webDriver) : base(locator, webDriver)
        {
        }
    }
}
