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
            var homePage = new ExamplePage(WebDriver);
            homePage.Visit();
            homePage.Verify();
        }
    }
}