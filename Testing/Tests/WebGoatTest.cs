using NUnit.Framework;
using Testing.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class WebGoatTest : BaseTest
    {
        WebGoatLoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            LoginPage = new WebGoatLoginPage(Configuration.ApplicationUrl, WebDriver);
            LoginPage.Visit();
            AssertUrl("/login.mvc");
        }

        private void AssertUrl(string expectedPath)
        {
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}{expectedPath}"));
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

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfullTest(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            lp.Logout();
            AssertUrl("/logout.mvc");
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LogoutTest(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            LoginPage = lp.Logout();
            Assert.That(LoginPage.AlertSuccess.Displayed, Is.True);
            Assert.That(LoginPage.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(LoginPage.LoginLink.Displayed, Is.True);
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}/logout.mvc"));
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            lp.EnableLabelDebugging();
            lp.UserMenu.Click();
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(lp.LessonProgressStatus.Displayed, Is.True);
            lp.Logout();
            AssertUrl("/logout.mvc");
        }
    }
}