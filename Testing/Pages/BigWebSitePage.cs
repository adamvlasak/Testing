using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePage : BasePage
    {
        public IWebElement Title => Wait.Until(driver => driver.FindElement(By.CssSelector(".logo--header")));
        public IWebElement Paragraph => Wait.Until(driver => driver.FindElement(By.CssSelector("p")));

        public BigWebsitePage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }
    }
}