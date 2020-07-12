using OpenQA.Selenium;

namespace Testing.Pages
{
    public class BigWebsitePage : BasePage
    {
        public IWebElement Title => WebDriver.FindElement(By.CssSelector(".logo--header"));
        public IWebElement Paragraph => WebDriver.FindElement(By.CssSelector("p"));

        public BigWebsitePage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
            Wait = CreateWebDriverWait(10);
        }

        public BigWebsitePage(IWebDriver driver) : base(driver)
        {
        }

        public void WaitForReady(System.Action action)
        {
            WebDriver.WaitForReady(Wait, "return window.jQuery != undefined && jQuery.active === 0;");
            action();
        }
    }
}