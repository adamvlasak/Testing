using NUnit.Framework;
using WebGoat.Extensions;
using WebGoat.Framework;
using WebGoat.Pages;

namespace WebGoat.Tests
{
    [TestFixture]
    public abstract class BaseWebGoatTest : BaseTest
    {
        public LoginPage LoginPage { get; private set; }

        protected LoggedInPage Login(string username, string password)
        {
            LoggedInPage loggedInPage = LoginPage.Login(username, password);
            Assert.That(loggedInPage.LessonTitle.Displayed, Is.True);
            Assert.That(loggedInPage.LessonTitle.Text, Is.EqualTo("How to work with WebGoat"));
            Assert.That(WebDriver.Url, Does.Contain(SiteMap.LoggedInPageUrl));
            return loggedInPage;
        }

        [SetUp]
        protected void SetUp()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            LoginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            LoginPage.Visit();
            Assert.That(WebDriver.Url, Does.Contain(SiteMap.LoginPageUrl));
        }

        [TearDown]
        protected void TearDown()
        {
            var context = TestContext.CurrentContext;
            if (context.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshot = WebDriver.Screenshot(Configuration.ScreenshotPath, context.Test.ClassName, context.Test.MethodName);
                TestContext.AddTestAttachment(screenshot);
            }
        }
    }
}
