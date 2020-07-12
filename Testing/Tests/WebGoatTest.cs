using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class WebGoatTest : BaseTest
    {
        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        public void LoginUnsuccessfullTest(string username, string password)
        {
            var p = new WebGoatLoginPage(new System.Uri("http://webapp:8080/WebGoat"), WebDriver);
            p.Visit();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            p.Login(username, password);
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc?error"));
            Assert.That(p.ErrorMessage.Displayed, Is.True);
            Assert.That(p.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfullTest(string username, string password)
        {
            var p = new WebGoatLoginPage(new System.Uri("http://webapp:8080/WebGoat"), WebDriver);
            p.Visit();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            var lp = p.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            lp.Logout();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/logout.mvc"));
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LogoutTest(string username, string password)
        {
            var p = new WebGoatLoginPage(new System.Uri("http://webapp:8080/WebGoat"), WebDriver);
            p.Visit();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            var lp = p.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            p = lp.Logout();
            Assert.That(p.AlertSuccess.Displayed, Is.True);
            Assert.That(p.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(p.LoginLink.Displayed, Is.True);
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/logout.mvc"));
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            var p = new WebGoatLoginPage(new System.Uri("http://webapp:8080/WebGoat"), WebDriver);
            p.Visit();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            var lp = p.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            lp.EnableLabelDebugging();
            lp.UserMenu.Click();
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(lp.LessonProgressStatus.Displayed, Is.True);
            lp.Logout();
            Assert.That(WebDriver.Url, Is.EqualTo("http://webapp:8080/WebGoat/logout.mvc"));
        }
    }
}