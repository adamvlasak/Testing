using OpenQA.Selenium;

namespace Testing.Pages
{
    public class ExamplePage : BasePage
    {
        public IWebElement Title => WebDriver.FindElement(By.TagName("h1"));
        public IWebElement Paragraph => WebDriver.FindElement(By.TagName("p"));

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }
    }
}