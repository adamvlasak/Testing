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

        protected void AssertUrl(string expectedPath)
        {
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}{expectedPath}"));
        }

        [SetUp]
        public void SetUp()
        {
            WebDriver.Manage().Cookies.DeleteAllCookies();
            LoginPage = new LoginPage(WebDriver, Configuration.ApplicationUrl);
            LoginPage.Visit();
            AssertUrl(SiteMap.LoginPageUrl);
        }

        [TearDown]
        public void TearDown()
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
