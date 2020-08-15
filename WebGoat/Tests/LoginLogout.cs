using NUnit.Framework;
using WebGoat.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    internal sealed class LoginLogout : BaseWebGoatTest
    {
        private LoginPage loginPage;

        [SetUp]
        public void SetUp()
        {
            loginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            loginPage.Visit();
            AssertUrl(SiteMap.LoginPageUrl);
        }

        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        public void LoginUnsuccessfullTest(string username, string password)
        {
            loginPage.Login(username, password);
            AssertUrl($"{SiteMap.LoginPageUrl}?error");
            Assert.That(loginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(loginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfullTest(string username, string password)
        {
            var loggedInPage = loginPage.Login(username, password);
            Assert.That(loggedInPage.LessonTitle.Displayed, Is.True);
            Assert.That(loggedInPage.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            loggedInPage.Logout();
            AssertUrl(SiteMap.LogoutPageUrl);
            Assert.That(loginPage.AlertSuccess.Displayed, Is.True);
            Assert.That(loginPage.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(loginPage.LoginLink.Displayed, Is.True);
            AssertUrl(SiteMap.LogoutPageUrl);
        }
    }
}
