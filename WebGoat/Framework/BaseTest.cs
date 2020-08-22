using NUnit.Framework;
using OpenQA.Selenium;

namespace WebGoat.Framework
{
    [SetUpFixture]
    public abstract class BaseTest
    {
        protected IWebDriver WebDriver { get; private set; }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            WebDriver = Factory.CreateWebDriver();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            WebDriver?.Quit();
        }
    }
}
