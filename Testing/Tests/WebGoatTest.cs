using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class WebGoatTest : BaseTest
    {
        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "foobar")]
        [TestCase("webgoat", "Webgoat")]
        public void LoginUnsuccessfulTest(string username, string password)
        {
            var p = new WebGoatLoginPage(driver);
            p.Login(username, password);
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
            p.Login(username, password);
            Assert.That(p.LessonTitle.Displayed, Is.True);
            Assert.That(p.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            p.Screenshot();
        }
    }
}