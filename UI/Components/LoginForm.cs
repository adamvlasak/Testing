using Framework.Components;
using Framework.Extensions;
using OpenQA.Selenium;

namespace UI.Components
{
    public class LoginForm : BaseComponent
    {
        public IWebElement UsernameInput => Element.FindElement(By.Id("exampleInputEmail1"));
        public IWebElement PasswordInput => Element.FindElement(By.Id("exampleInputPassword1"));
        public IWebElement SubmitButton => Element.FindElement(By.CssSelector("button.btn-primary"));

        public LoginForm(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

        public void Fill(string username, string password)
        {
            UsernameInput.SendKeys(username);
            PasswordInput.SendKeys(password);
        }

        public void Submit()
        {
            SubmitButton.Click();
        }
    }
}
