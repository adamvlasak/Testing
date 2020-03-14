using NUnit.Framework;
using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePage : BasePage
    {
        //IWebElement Title => _wait.Until(driver => driver.FindElement(By.CssSelector(".logo--header")));
        [Skip(AutoCheck = false)]
        IWebElement Title => _driver.FindElement(By.CssSelector(".logo--header"));
        [Skip(AutoCheck = true)]
        IWebElement Paragraph => _wait.Until(driver => driver.FindElement(By.CssSelector("p")));

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://wired.com");
        }

        public void Verify()
        {
            Assert.That(Title.Displayed, Is.True, "Title not found on the page");
            Assert.That(Paragraph.Displayed, Is.True);
        }
    }
}