using OpenQA.Selenium;
using WebGoat.Extensions;

namespace WebGoat.Components
{
    public class LoginForm : BaseComponent
    {
        public LoginForm(IWebDriver webDriver, IWebElement element) : base(webDriver, element)
        {
        }

        public IWebElement UsernameInput => Element.FindElementWithWait(By.Id("exampleInputEmail1"));
        public IWebElement PasswordInput => Element.FindElementWithWait(By.Id("exampleInputPassword1"));
        public IWebElement SubmitButton => Element.FindElementWithWait(By.CssSelector("button.btn-primary"));

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
