using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebGoat.Components
{
    public class LoginForm : BaseComponent
    {
        public LoginForm(IWebDriver driver, WebDriverWait wait, IWebElement element) : base(driver, wait, element)
        {
        }

        public IWebElement UsernameInput => WrappedElement.FindElement(By.Id("exampleInputEmail1"));
        public IWebElement PasswordInput => WrappedElement.FindElement(By.Id("exampleInputPassword1"));
        public IWebElement SubmitButton => WrappedElement.FindElement(By.CssSelector("button.btn-primary"));

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
