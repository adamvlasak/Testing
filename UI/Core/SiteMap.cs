using Framework.Core;
using System;

namespace UI.Core
{
    /// <summary>
    /// Provides URLs used in application under test.
    /// </summary>
    public static class SiteMap
    {
        public static Uri LoginPageUrl => new($"{Configuration.ApplicationUrl}/login.mvc");
        public static Uri LogoutPageUrl => new($"{Configuration.ApplicationUrl}/logout.mvc");
        public static Uri Lesson1PageUrl => LessonLinks.GetById(360466308).Url;
    }
}
