using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing.Pages
{
    public class WebGoatLoginPage : BasePage
    {
        public WebGoatLoginPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl("http://localhost:8080/WebGoat");
        }

        public WebGoatRegistrationPage Register()
        {
            return new WebGoatRegistrationPage(_driver);
        }
    }
}
