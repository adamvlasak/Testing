using NUnit.Framework;

namespace WebGoat.Tests
{
    public class BaseWebGoatTest : BaseTest
    {
        protected void AssertUrl(string expectedPath)
        {
            Assert.That(WebDriver.Url, Is.EqualTo($"{Configuration.ApplicationUrl}{expectedPath}"));
        }
    }
}