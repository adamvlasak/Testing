using NUnit.Framework;
using UI.Pages;

namespace UI.Tests.Lessons
{
    [TestFixture]
    public sealed class Lesson1Tests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson1(string username, string password)
        {
            LessonPage loggedInPage = Login(username, password);
            loggedInPage.EnableLabelDebugging();
            Assert.That(loggedInPage.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(loggedInPage.LessonProgressStatus.Displayed, Is.True);
            loggedInPage.DisableLabelDebugging();
            Logout(loggedInPage);
        }
    }
}
