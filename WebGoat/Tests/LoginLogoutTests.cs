using NUnit.Framework;
using WebGoat.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    internal sealed class LoginLogoutTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        public void LoginUnsuccessfull(string username, string password)
        {
            LoginPage.Login(username, password);
            Assert.That(WebDriver.Url, Does.Contain($"{SiteMap.LoginPageUrl}?error"));
            Assert.That(LoginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(LoginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfull(string username, string password)
        {
            LoggedInPage loggedInPage = base.Login(username, password);
            base.Logout(loggedInPage);
        }
    }
}
