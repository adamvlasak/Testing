using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePageSync : BasePage
    {
        public IWebElement Title => Wait.Until(driver => driver.FindElement(By.CssSelector(".logo--header")));
        public IWebElement App => Wait.Until(driver => driver.FindElement(By.CssSelector("div#app-root")));

        public BigWebsitePageSync(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public BigWebsitePageSync(IWebDriver driver) : base(driver)
        {
        }
    }
}