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
            var p = new BigWebsitePage(WebDriver);
            p.Visit();
            Assert.That(p.Title.Displayed, Is.True, "Title not found on the web page");
            Assert.That(p.Paragraph.Displayed, Is.True, "No paragraph found on the web page");
        }
    }
}