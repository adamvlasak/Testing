using NUnit.Framework;
using Testing.Pages;

namespace Testing.Tests
{
    [TestFixture]
    public class ExampleTest : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            var p = new ExamplePage(new System.Uri("https://example.org"), WebDriver);
            p.Visit();
            Assert.That(p.Title.Displayed, Is.True);
            Assert.That(p.Paragraph.Displayed, Is.True);
        }
    }
}