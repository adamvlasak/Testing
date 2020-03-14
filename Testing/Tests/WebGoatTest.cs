using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class WebGoatTest : BaseTest
    {
        [Test]
        public void LoginUnsuccessfulTest()
        {
            var p = new WebGoatLoginPage(driver);
            p.Login("guest", "foobar");
            Assert.That(p.ErrorMessage.Displayed, Is.True);
            Assert.That(p.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }

        [Test]
        public void LoginSuccessfulTest()
        {
            var p = new WebGoatLoginPage(driver);
            p.Login("guest", "guest");
            Assert.That(p.LessonTitle.Displayed, Is.True);
            Assert.That(p.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
        }
    }
}