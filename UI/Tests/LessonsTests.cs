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
            LoggedInPage loggedInPage = base.Login(username, password);
            loggedInPage.EnableLabelDebugging();
            Assert.That(loggedInPage.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(loggedInPage.LessonProgressStatus.Displayed, Is.True);
            base.Logout(loggedInPage);
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LessonsSmoke(string username, string password)
        {
            LoggedInPage loggedInPage = base.Login(username, password);
            loggedInPage.OpenLesson("Web Service SQL Injection");
            loggedInPage.OpenLesson("JSON Injection");
            loggedInPage.OpenLesson("Thread Safety Problems");
            loggedInPage.OpenLesson("Denial of Service from Multiple Logins");
            loggedInPage.OpenLesson("The CHALLENGE");
            base.Logout(loggedInPage);
        }
    }
}