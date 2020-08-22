using System;

namespace WebGoat.Framework
{
    /// <summary>
    /// Provides URLs used in application under test.
    /// </summary>
    public static class SiteMap
    {
        public static Uri LoginPageUrl => new Uri($"{Configuration.ApplicationUrl}/login.mvc");
        public static Uri LogoutPageUrl => new Uri($"{Configuration.ApplicationUrl}/logout.mvc");
        public static Uri LoggedInPageUrl => new Uri($"{Configuration.ApplicationUrl}/start.mvc#attack/360466308/5");
    }
}
