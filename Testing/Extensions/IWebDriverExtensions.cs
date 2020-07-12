using OpenQA.Selenium.Support.UI;
using System.IO;

namespace OpenQA.Selenium
{
    public static class IWebDriverExtensions
    {
        public static void Screenshot(this IWebDriver driver)
        {
            var path = "c:\\tmp";
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            screenshot.SaveAsFile($"{path}\\{System.DateTime.Now.ToString("yyyy-dd-MM--HH-mm-ss")}.png", ScreenshotImageFormat.Png);
        }
    }
}
