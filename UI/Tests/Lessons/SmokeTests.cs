using NUnit.Framework;
using UI.Pages;

namespace UI.Tests.Lessons
{
    public sealed class SmokeTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void LessonsSmoke(string username, string password)
        {
            LessonPage loggedInPage = Login(username, password);
            loggedInPage.OpenLesson("Web Service SQL Injection");
            loggedInPage.OpenLesson("JSON Injection");
            loggedInPage.OpenLesson("Thread Safety Problems");
            loggedInPage.OpenLesson("Denial of Service from Multiple Logins");
            loggedInPage.OpenLesson("The CHALLENGE");
            Logout(loggedInPage);
        }
    }
}
