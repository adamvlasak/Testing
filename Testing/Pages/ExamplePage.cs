using OpenQA.Selenium;

namespace Testing.Pages
{
    public class ExamplePage : BasePage
    {
        public IWebElement title => WebDriver.FindElement(By.TagName("h1"));
        public IWebElement paragraph => WebDriver.FindElement(By.TagName("p"));

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            WebDriver.Navigate().GoToUrl("https://example.org");
        }
    }
}