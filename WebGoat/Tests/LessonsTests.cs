using NUnit.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    internal sealed class LessonsTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            LoggedInPage lp = base.Login(username, password);
            lp.EnableLabelDebugging();
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(lp.LessonProgressStatus.Displayed, Is.True);
            Logout(lp);
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LessonsSmoke(string username, string password)
        {
            LoggedInPage lp = base.Login(username, password);
            lp.OpenLesson("Web Service SQL Injection");
            lp.OpenLesson("JSON Injection");
            lp.OpenLesson("Thread Safety Problems");
            lp.OpenLesson("Denial of Service from Multiple Logins");
            lp.OpenLesson("The CHALLENGE");
            Logout(lp);
        }
    }
}
