using NUnit.Framework;
using OpenQA.Selenium;

namespace Testing.Pages
{
    public class ExamplePage : BasePage
    {
        private IWebElement title => _driver.FindElement(By.TagName("h1"));
        private IWebElement paragraph => _driver.FindElement(By.TagName("p"));

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://example.org");
        }

        public void Verify()
        {
            Assert.That(title.Displayed, Is.True);
            Assert.That(paragraph.Displayed, Is.True);
        }
    }
}