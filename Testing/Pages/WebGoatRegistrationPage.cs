using OpenQA.Selenium;

namespace Testing.Pages
{
    public class WebGoatRegistrationPage : BasePage
    {
        public WebGoatRegistrationPage(IWebDriver driver) : base(driver)
        {
            WebDriver.Navigate().GoToUrl("http://webapp:8080/WebGoat/registration");
        }

        public WebGoatLoginPage Login()
        {
            return new WebGoatLoginPage(WebDriver);
        }
    }
}