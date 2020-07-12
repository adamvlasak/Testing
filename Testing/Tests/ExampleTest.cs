using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class ExampleTest : BaseTest
    {
        [Test]
        public void NoWaitForReady()
        {
            var p = new ExamplePage(new System.Uri("https://example.org"), WebDriver);
            p.Visit();
            Assert.That(p.Title.Displayed, Is.True);
            Assert.That(p.Paragraph.Displayed, Is.True);
        }

        [Test]
        public void WaitForReady()
        {
            var p = new ExamplePage(new System.Uri("https://example.org"), WebDriver);
            p.Visit();
            p.WaitForReady();
            Assert.That(p.Title.Displayed, Is.True);
            Assert.That(p.Paragraph.Displayed, Is.True);
        }
    }
}