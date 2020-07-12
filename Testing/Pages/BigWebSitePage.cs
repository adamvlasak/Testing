using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePage : BasePage
    {
        public IWebElement Title => WebDriver.FindElement(By.CssSelector(".logo--header"));
        public IWebElement App => WebDriver.FindElement(By.CssSelector("div#app-root"));

        public BigWebsitePage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
            Wait = CreateWebDriverWait(10);
        }

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }

        public void WaitForReady()
        {
            WebDriver.WaitForReady(Wait, "return window.jQuery != undefined && window.jQuery.active === 0;");
        }

        public void WaitForReady(System.Action action)
        {
            WaitForReady();
            action();
        }
    }
}