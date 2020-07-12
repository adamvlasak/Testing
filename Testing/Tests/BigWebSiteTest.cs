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
            var p = new BigWebsitePage(new System.Uri("https://wired.com"), WebDriver);
            p.Visit(() => System.Console.WriteLine($"Hello from {WebDriver.Url}"));
            p.WaitForReady(() =>
            {
                Assert.That(p.Title.Displayed, Is.True, $"Title not found on the web page {WebDriver.Url}");
                Assert.That(p.Paragraph.Displayed, Is.True, "No paragraph found on the web page");
            });

            WebDriver.Navigate().Refresh();

            p.WaitForReady(() =>
            {
                Assert.That(p.Title.Displayed, Is.True, $"Title not found on the web page {WebDriver.Url}");
                Assert.That(p.Paragraph.Displayed, Is.True, "No paragraph found on the web page");
            });
        }
    }
}