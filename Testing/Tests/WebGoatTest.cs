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
        public void LoginUnsuccessfulTest(string username, string password)
        {
            var p = new WebGoatLoginPage(driver);
            p.Visit();
            Assert.That(driver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            p.Login(username, password);
            Assert.That(driver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc?error"));
            Assert.That(p.ErrorMessage.Displayed, Is.True);
            Assert.That(p.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
            p.Screenshot();
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LoginSuccessfulTest(string username, string password)
        {
            var p = new WebGoatLoginPage(driver);
            p.Visit();
            Assert.That(driver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            var lp = p.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            Assert.That(lp.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            p.Screenshot();
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LogoutTest(string username, string password)
        {
            var p = new WebGoatLoginPage(driver);
            p.Visit();
            Assert.That(driver.Url, Is.EqualTo("http://webapp:8080/WebGoat/login.mvc"));
            var lp = p.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            p = lp.Logout();
            Assert.That(p.AlertSuccess.Displayed, Is.True);
            Assert.That(p.LoginLink.Displayed, Is.True);
            Assert.That(driver.Url, Is.EqualTo("http://webapp:8080/WebGoat/logout.mvc"));
            p.Screenshot();
        }
    }
}