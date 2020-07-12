using OpenQA.Selenium;

namespace Testing.Pages
{
    public sealed class ExamplePage : BasePage
    {
        public IWebElement Title => WebDriver.FindElement(By.TagName("h1"));
        public IWebElement Paragraph => WebDriver.FindElement(By.TagName("p"));

        public ExamplePage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        public void WaitForReady()
        {
            WebDriver.WaitForReady(Wait, FrontendFramework.vanilla);
        }
    }
}