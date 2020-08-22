using OpenQA.Selenium;
using WebGoat.Components;
using WebGoat.Extensions;
using WebGoat.Framework;

namespace WebGoat.Pages
{
    public sealed class LoginPage : BasePage
    {
        public IWebElement ErrorMessage => WebDriver.FindElementWithWait(By.CssSelector("div.error"));
        public IWebElement AlertSuccess => WebDriver.FindElementWithWait(By.CssSelector("div.alert-success"));
        public IWebElement LoginLink => WebDriver.FindElementWithWait(By.CssSelector("h4 a"));

        private LoginForm _loginForm;
        public LoginForm LoginForm => _loginForm != null ? _loginForm : _loginForm = WebDriver.FindElementWithWait<LoginForm>(By.CssSelector("form[name='loginForm']"));

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
            return new LoggedInPage(WebDriver);
        }
    }
}
