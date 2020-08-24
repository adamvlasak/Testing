using Framework.Core;
using Framework.Extensions;
using NUnit.Framework;
using WebGoat.Core;
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
            Assert.That(WebDriver.Url, Is.EqualTo(SiteMap.LoggedInPageUrl));
            return loggedInPage;
        }

        protected void Logout(LoggedInPage loggedInPage)
        {
            LogoutPage logoutPage = loggedInPage.Logout();
            Assert.That(logoutPage.AlertSuccess.Displayed, Is.True);
            Assert.That(logoutPage.AlertSuccess.Text, Is.EqualTo("You have logged out successfully"));
            Assert.That(logoutPage.LoginLink.Displayed, Is.True);
            Assert.That(WebDriver.Url, Is.EqualTo(SiteMap.LogoutPageUrl));
        }

        [SetUp]
        protected void SetUp()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            LoginPage = new LoginPage(WebDriver, SiteMap.LoginPageUrl);
            LoginPage.Visit();
            Assert.That(WebDriver.Url, Is.EqualTo(SiteMap.LoginPageUrl));
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
