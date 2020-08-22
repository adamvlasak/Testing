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
            AssertUrl($"{SiteMap.LoginPageUrl}?error");
            Assert.That(LoginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(LoginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfull(string username, string password)
        {
            var loggedInPage = LoginPage.Login(username, password);
            Assert.That(loggedInPage.LessonTitle.Displayed, Is.True);
            Assert.That(loggedInPage.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            loggedInPage.Logout();
            AssertUrl(SiteMap.LogoutPageUrl);
            Assert.That(LoginPage.AlertSuccess.Displayed, Is.True);
            Assert.That(LoginPage.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(LoginPage.LoginLink.Displayed, Is.True);
            AssertUrl(SiteMap.LogoutPageUrl);
        }
    }
}
