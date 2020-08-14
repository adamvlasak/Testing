using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebGoat.Framework;

namespace WebGoat.Components
{
    public abstract class BaseObject
    {
        public WebDriverWait Wait { get; }

        public IWebDriver WebDriver { get; }

        public BaseObject(IWebDriver driver)
        {
            WebDriver = driver;
            Wait = Factory.CreateWebDriverWait(WebDriver);
        }
    }
}
