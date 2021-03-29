using Framework.Components;
using Framework.Core;
using OpenQA.Selenium;
using System;
using UI.Components;
using UI.Core;

namespace UI.Pages
{
    public sealed class LoginPage : BasePage
    {
        public WebElement ErrorMessage => new(By.CssSelector("div.error"), WebDriver);

        public LoginForm LoginForm => new(By.CssSelector("form[name='loginForm']"), WebDriver);

        public Table LoginsTable => new(By.TagName("table"), WebDriver);

        public LoginPage(IWebDriver webDriver, Uri url) : base(webDriver, url)
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
