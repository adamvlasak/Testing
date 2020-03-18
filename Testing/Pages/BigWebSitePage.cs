using NUnit.Framework;
using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePage : BasePage
    {
        private IWebElement Title => WebDriver.FindElement(By.CssSelector(".logo--header"));

        private IWebElement Paragraph => Wait.Until(driver => driver.FindElement(By.CssSelector("p")));

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            WebDriver.Navigate().GoToUrl("https://wired.com");
        }

        public void Verify()
        {
            Assert.That(Title.Displayed, Is.True, "Title not found on the page");
            Assert.That(Paragraph.Displayed, Is.True);
        }
    }
}