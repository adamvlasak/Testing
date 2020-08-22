using NUnit.Framework;
using WebGoat.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    internal sealed class Lessons : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            lp.EnableLabelDebugging();
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(lp.LessonProgressStatus.Displayed, Is.True);
            lp.Logout();
            AssertUrl(SiteMap.LogoutPageUrl);
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson2(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            lp.OpenLesson("Web Service SQL Injection");
            lp.OpenLesson("JSON Injection");
            lp.OpenLesson("Thread Safety Problems");
            lp.OpenLesson("Denial of Service from Multiple Logins");
            lp.OpenLesson("The CHALLENGE");
            lp.Logout();
            AssertUrl(SiteMap.LogoutPageUrl);
        }
    }
}
