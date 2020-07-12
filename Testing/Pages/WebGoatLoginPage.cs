using OpenQA.Selenium;
using System;

namespace Testing.Pages
{
    public sealed class WebGoatLoginPage : BasePage
    {
        public IWebElement Username => Wait.Until(driver => driver.FindElement(By.Id("exampleInputEmail1")));
        public IWebElement Password => Wait.Until(driver => driver.FindElement(By.Id("exampleInputPassword1")));
        public IWebElement Submit => Wait.Until(driver => driver.FindElement(By.CssSelector("button.btn-primary")));
        public IWebElement ErrorMessage => Wait.Until(driver => driver.FindElement(By.CssSelector("div.error")));
        public IWebElement AlertSuccess => Wait.Until(driver => driver.FindElement(By.CssSelector("div.alert-success")));
        public IWebElement LoginLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));
        public IWebElement RegisterLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));

        public WebGoatLoginPage(System.Uri baseUrl, IWebDriver driver) : base(baseUrl, driver)
        {
        }

        public WebGoatLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public WebGoatLoggedInPage Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
            return new WebGoatLoggedInPage(WebDriver);
        }

        public void WaitForReady()
        {
            WebDriver.WaitForReady(Wait, FrontendFramework.vanilla);
        }
    }
}