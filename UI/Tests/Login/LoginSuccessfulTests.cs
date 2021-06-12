using NUnit.Framework;
using UI.Pages;

namespace UI.Tests.Login
{
    [TestFixture]
    public sealed class LoginSuccessFulTests : BaseWebGoatTest
    {
        [TestCase("guest", "guest")]
        [TestCase("webgoat", "webgoat")]
        [TestCase("server", "server")]
        [Category("login")]
        public void LoginSuccessFul(string username, string password)
        {
            LessonPage loggedInPage = Login(username, password);
            Logout(loggedInPage);
        }
    }
}
