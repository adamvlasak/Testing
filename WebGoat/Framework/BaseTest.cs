using NUnit.Framework;
using OpenQA.Selenium;

namespace WebGoat.Framework
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
