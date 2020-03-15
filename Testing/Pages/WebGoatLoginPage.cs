using OpenQA.Selenium;

namespace Testing.Pages
{
    public class WebGoatLoginPage : BasePage
    {
        public IWebElement Username => _wait.Until(driver => driver.FindElement(By.Id("exampleInputEmail1")));
        public IWebElement Password => _wait.Until(driver => driver.FindElement(By.Id("exampleInputPassword1")));
        public IWebElement Submit => _wait.Until(driver => driver.FindElement(By.CssSelector("button.btn-primary")));
        public IWebElement ErrorMessage => _wait.Until(driver => driver.FindElement(By.CssSelector("div.error")));
        public IWebElement AlertSuccess => _wait.Until(driver => driver.FindElement(By.CssSelector("div.alert-success")));
        public IWebElement LoginLink => _wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));

        public WebGoatLoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("http://webapp:8080/WebGoat");
        }

        public LoggedInHomePage Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
            return new LoggedInHomePage(_driver);
        }

        public WebGoatRegistrationPage Register()
        {
            return new WebGoatRegistrationPage(_driver);
        }
    }
}