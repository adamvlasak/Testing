using NUnit.Framework;
using OpenQA.Selenium;
using WebGoat.Extensions;

namespace WebGoat.Framework
{
    [SetUpFixture]
    public class BaseTest
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
