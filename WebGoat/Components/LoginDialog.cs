using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebGoat.Components
{
    public class LoginDialog : BaseComponent
    {
        public LoginDialog(IWebDriver driver, WebDriverWait wait, IWebElement element) : base(driver, wait, element)
        {
        }

        public IWebElement Username => WrappedElement.FindElement(By.Id("exampleInputEmail1"));
        public IWebElement Password => WrappedElement.FindElement(By.Id("exampleInputPassword1"));
        public IWebElement Submit => WrappedElement.FindElement(By.CssSelector("button.btn-primary"));
    }
}
