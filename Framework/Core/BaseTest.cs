using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Core
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        [OneTimeSetUp]
        protected void OneTimeSetup()
        {
            WebDriver = Factory.CreateWebDriver();
        }

        [OneTimeTearDown]
        protected void OneTimeTearDown()
        {
            WebDriver?.Quit();
        }
    }
}
