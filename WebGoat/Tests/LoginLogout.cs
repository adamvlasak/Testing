using NUnit.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    internal sealed class LoginLogout : BaseWebGoatTest
    {
        private LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            LoginPage.Visit();
            AssertUrl("/login.mvc");
        }

        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        public void LoginUnsuccessfullTest(string username, string password)
        {
            LoginPage.Login(username, password);
            AssertUrl("/login.mvc?error");
            Assert.That(LoginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(LoginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfullTest(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            lp.Logout();
            AssertUrl("/logout.mvc");
            Assert.That(LoginPage.AlertSuccess.Displayed, Is.True);
            Assert.That(LoginPage.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(LoginPage.LoginLink.Displayed, Is.True);
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}/logout.mvc"));
        }
    }
}
