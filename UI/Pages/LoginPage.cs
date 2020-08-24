using Framework.Core;
using Framework.Extensions;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public sealed class LoginPage : BasePage
    {
        public IWebElement ErrorMessage => WebDriver.FindElementWithWait(By.CssSelector("div.error"));
        private LoginForm _loginForm;
        public LoginForm LoginForm => _loginForm ??= WebDriver.FindElementWithWait<LoginForm>(By.CssSelector("form[name='loginForm']"));

        public LoginPage(IWebDriver webDriver, Uri baseUrl) : base(webDriver, baseUrl)
        {
        }

        public Lesson1Page Login(string username, string password)
        {
            LoginForm.Fill(username, password);
            LoginForm.Submit();
            return new Lesson1Page(WebDriver, SiteMap.Lesson1PageUrl);
        }
    }
}
