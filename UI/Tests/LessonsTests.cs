using NUnit.Framework;
using UI.Pages;

namespace UI.Tests
{
    [TestFixture]
    public sealed class LessonsTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            LessonPage loggedInPage = base.Login(username, password);
            loggedInPage.EnableLabelDebugging();
            Assert.That(loggedInPage.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(loggedInPage.LessonProgressStatus.Displayed, Is.True);
            loggedInPage.DisableLabelDebugging();
            base.Logout(loggedInPage);
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LessonsSmoke(string username, string password)
        {
            LessonPage loggedInPage = base.Login(username, password);
            loggedInPage.OpenLesson("Web Service SQL Injection");
            loggedInPage.OpenLesson("JSON Injection");
            loggedInPage.OpenLesson("Thread Safety Problems");
            loggedInPage.OpenLesson("Denial of Service from Multiple Logins");
            loggedInPage.OpenLesson("The CHALLENGE");
            base.Logout(loggedInPage);
        }
    }
}
