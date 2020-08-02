using NUnit.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    class Lessons : BaseTest
    {
        private LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage(Configuration.ApplicationUrl, WebDriver);
            LoginPage.Visit();
            AssertUrl("/login.mvc");
        }

        private void AssertUrl(string expectedPath)
        {
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}{expectedPath}"));
        }

        [Test]
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        public void CompleteLesson(string username, string password)
        {
            var lp = LoginPage.Login(username, password);
            Assert.That(lp.LessonTitle.Displayed, Is.True);
            lp.EnableLabelDebugging();
            lp.UserMenu.Click();
            Assert.That(lp.LessonProgressStatus.Text, Is.EqualTo("Congratulations. You have successfully completed this lesson."));
            Assert.That(lp.LessonProgressStatus.Displayed, Is.True);
            lp.Logout();
            AssertUrl("/logout.mvc");
        }
    }
}
