using NUnit.Framework;
using OpenQA.Selenium;

namespace Testing.Pages
{
    public class ExamplePage : BasePage
    {
        private IWebElement title => WebDriver.FindElement(By.TagName("h1"));
        private IWebElement paragraph => WebDriver.FindElement(By.TagName("p"));

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            WebDriver.Navigate().GoToUrl("https://example.org");
        }

        public void Verify()
        {
            Assert.That(title.Displayed, Is.True);
            Assert.That(paragraph.Displayed, Is.True);
        }
    }
}