using OpenQA.Selenium;

namespace Testing.Pages
{
    public class WebGoatLoginPage : BasePage
    {
        public WebGoatLoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("http://webapp:8080/WebGoat");
        }

        public WebGoatRegistrationPage Register()
        {
            return new WebGoatRegistrationPage(_driver);
        }
    }
}