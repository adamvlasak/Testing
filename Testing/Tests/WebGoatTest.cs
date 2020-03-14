using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class WebGoatTest : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var homePage = new WebGoatLoginPage(driver);
            homePage.Screenshot();
            var registrationPage = homePage.Register();
            registrationPage.Screenshot();
            registrationPage.Login();
            registrationPage.Screenshot();
        }
    }
}
