using Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Components
{
    public abstract class BaseObject
    {
        public WebDriverWait Wait { get; }

        public IWebDriver WebDriver { get; }

        protected BaseObject(IWebDriver driver)
        {
            WebDriver = driver;
            Wait = Factory.CreateWebDriverWait(WebDriver);
        }

        protected string LogMessage(string message)
        {
            return $"{DateTime.Now} ~ {this} ~ {message}";
        }
    }
}
