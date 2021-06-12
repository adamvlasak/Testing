using Framework.Components;
using OpenQA.Selenium;

namespace UI.Components
{
    public class LoginForm : BaseComponent
    {
        public TextBox UsernameInput => new(By.Id("exampleInputEmail1"), WebDriver, Element);
        public TextBox PasswordInput => new(By.Id("exampleInputPassword1"), WebDriver, Element);
        public WebElement SubmitButton => new(By.CssSelector("button.btn-primary"), WebDriver, Element);

        public LoginForm(By locator, IWebDriver webDriver) : base(locator, webDriver)
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
