using NUnit.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    internal class Lessons : BaseWebGoatTest
    {
        private LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            LoginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            LoginPage.Visit();
            AssertUrl("/login.mvc");
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
