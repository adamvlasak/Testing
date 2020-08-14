using OpenQA.Selenium;
using WebGoat.Components;
using WebGoat.Extensions;

namespace WebGoat.Pages
{
    public sealed class LoginPage : BaseWebGoatPage
    {
        public IWebElement ErrorMessage => Wait.Until(driver => driver.FindElement(By.CssSelector("div.error")));
        public IWebElement AlertSuccess => Wait.Until(driver => driver.FindElement(By.CssSelector("div.alert-success")));
        public IWebElement LoginLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));
        public IWebElement RegisterLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));

        private LoginForm _loginForm;

        public LoginForm LoginForm
        {
            get
            {
                if (_loginForm != null)
                    return _loginForm;

                var form = Wait.Until(d => d.FindElement(By.CssSelector("form[name='loginForm']")));
                _loginForm = new LoginForm(WebDriver, form);
                return _loginForm;
            }
        }

        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public LoginPage(IWebDriver webDriver, System.Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public LoggedInPage Login(string username, string password)
        {
            LoginForm.Fill(username, password);
            LoginForm.Submit();
            WebDriver.WaitForReady(Wait);
            return new LoggedInPage(WebDriver);
        }
    }
}
