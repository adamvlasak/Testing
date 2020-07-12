using OpenQA.Selenium;

namespace Testing.Pages
{
    public sealed class BigWebsitePage : BasePage
    {
        public IWebElement Title => WebDriver.FindElement(By.CssSelector(".logo--header"));
        public IWebElement App => WebDriver.FindElement(By.CssSelector("div#app-root"));

        public BigWebsitePage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }

        // could be in BasePage when FE is consistent
        public void WaitForReady()
        {
            WebDriver.WaitForReady(Wait, "return window.jQuery != undefined && window.jQuery.active === 0;");
        }

        // handy for test case
        public void WaitForReady(System.Action action)
        {
            WaitForReady();
            action();
        }
    }
}