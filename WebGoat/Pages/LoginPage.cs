using OpenQA.Selenium;
using System;
using WebGoat.Components;
using WebGoat.Extensions;
using WebGoat.Framework;

namespace WebGoat.Pages
{
    public sealed class LoginPage : BasePage
    {
        public IWebElement ErrorMessage => WebDriver.FindElementWithWait(By.CssSelector("div.error"));
        private LoginForm _loginForm;
        public LoginForm LoginForm => _loginForm ??= WebDriver.FindElementWithWait<LoginForm>(By.CssSelector("form[name='loginForm']"));

        public LoginPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public LoggedInPage Login(string username, string password)
        {
            LoginForm.Fill(username, password);
            LoginForm.Submit();
            return new LoggedInPage(WebDriver, SiteMap.LoggedInPageUrl);
        }
    }
}
