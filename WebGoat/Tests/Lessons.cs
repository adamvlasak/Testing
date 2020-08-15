using NUnit.Framework;
using WebGoat.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    internal sealed class Lessons : BaseWebGoatTest
    {
        private LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            LoginPage.Visit();
            AssertUrl(SiteMap.LoginPageUrl);
        }

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
    }
}
