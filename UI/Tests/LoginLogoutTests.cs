using NUnit.Framework;
using UI.Core;
using UI.Pages;

namespace UI.Tests
{
    [TestFixture]
    public sealed class LoginLogoutTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        [TestCase("server", "Server")]
        public void LoginUnsuccessfull(string username, string password)
        {
            LoginPage.Login(username, password);
            Assert.That(WebDriver.Url, Is.EqualTo($"{SiteMap.LoginPageUrl}?error"));
            Assert.That(LoginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(LoginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        [TestCase("server", "server")]
        public void LoginSuccessfull(string username, string password)
        {
            LessonPage loggedInPage = base.Login(username, password);
            base.Logout(loggedInPage);
        }
    }
}
