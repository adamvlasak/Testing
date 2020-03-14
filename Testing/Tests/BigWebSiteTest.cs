using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class BigWebSiteTest : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var homePage = new BigWebsitePage(driver);
            homePage.Visit();
            homePage.Screenshot();
        }
    }
}