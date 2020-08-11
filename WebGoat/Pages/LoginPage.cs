using OpenQA.Selenium;
using WebGoat.Components;

namespace WebGoat.Pages
{
    public sealed class LoginPage : BaseWebGoatPage
    {
        public IWebElement ErrorMessage => Wait.Until(driver => driver.FindElement(By.CssSelector("div.error")));
        public IWebElement AlertSuccess => Wait.Until(driver => driver.FindElement(By.CssSelector("div.alert-success")));
        public IWebElement LoginLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));
        public IWebElement RegisterLink => Wait.Until(driver => driver.FindElement(By.CssSelector("h4 a")));

        private LoginDialog _loginDialog;

        public LoginDialog LoginDialog
        {
            get
            {
                if (_loginDialog != null)
                    return _loginDialog;

                var form = Wait.Until(d => d.FindElement(By.CssSelector("form[name='loginForm']")));
                _loginDialog = new LoginDialog(WebDriver, Wait, form);
                return _loginDialog;
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
            LoginDialog.Username.SendKeys(username);
            LoginDialog.Password.SendKeys(password);
            LoginDialog.Submit.Click();
            WebDriver.WaitForReady(Wait);
            return new LoggedInPage(WebDriver);
        }
    }
}
