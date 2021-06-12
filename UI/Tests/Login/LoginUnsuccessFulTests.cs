using NUnit.Framework;
using UI.Core;
using UI.Pages;

namespace UI.Tests.Login
{
    [TestFixture]
    public sealed class LoginUnSuccessFulTests : BaseWebGoatTest
    {
        [Test]
        [TestCase("guest", "Guest")]
        [TestCase("admin", "admin")]
        [TestCase("webgoat", "Webgoat")]
        [TestCase("webgoat", "")]
        [TestCase("server", "Server")]
        public void LoginUnSuccessFul(string username, string password)
        {
            LoginPage.Login(username, password);
            Assert.That(WebDriver.Url, Is.EqualTo($"{SiteMap.LoginPageUrl}?error"));
            Assert.That(LoginPage.ErrorMessage.Displayed, Is.True);
            Assert.That(LoginPage.ErrorMessage.Text, Is.EqualTo("Invalid username and password!"));
        }
    }
}
