using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebGoat.Components
{
    public class LoginForm : BaseComponent
    {
        public LoginForm(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

        public IWebElement UsernameInput => Element.FindElement(By.Id("exampleInputEmail1"));
        public IWebElement PasswordInput => Element.FindElement(By.Id("exampleInputPassword1"));
        public IWebElement SubmitButton => Element.FindElement(By.CssSelector("button.btn-primary"));

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
