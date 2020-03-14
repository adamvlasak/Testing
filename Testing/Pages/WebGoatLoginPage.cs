using OpenQA.Selenium;

namespace Testing.Pages
{
    public class WebGoatLoginPage : BasePage
    {
        public IWebElement Username => _wait.Until(driver => driver.FindElement(By.Id("exampleInputEmail1")));
        public IWebElement Password => _wait.Until(driver => driver.FindElement(By.Id("exampleInputPassword1")));
        public IWebElement Submit => _wait.Until(driver => driver.FindElement(By.CssSelector("button.btn-primary")));
        public IWebElement ErrorMessage => _wait.Until(driver => driver.FindElement(By.CssSelector("div.error")));
        public IWebElement LessonTitle => _wait.Until(driver => driver.FindElement(By.CssSelector("h1#lesson-title")));

        public WebGoatLoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("http://webapp:8080/WebGoat");
        }

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            Submit.Click();
        }

        public WebGoatRegistrationPage Register()
        {
            return new WebGoatRegistrationPage(_driver);
        }
    }
}