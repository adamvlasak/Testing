using OpenQA.Selenium;
using System.IO;

namespace Framework.Extensions
{
    public static class IWebDriverExtensions
    {
        /// <summary>
        /// Saves screenshot and returns its filename.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="path">Path to screenshots</param>
        /// <param name="className">(Test) Class name where error happened</param>
        /// <param name="methodName">(Test) Method test name where error happened</param>
        /// <returns></returns>
        public static string Screenshot(this IWebDriver driver, string path, string className, string methodName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var fileName = $"{path}{Path.DirectorySeparatorChar}{System.DateTime.Now:yyyy-MM-dd_HH-mm-ss}_{className}_{methodName}.png";

            screenshot.SaveAsFile($"{fileName}", ScreenshotImageFormat.Png);

            return fileName;
        }
    }
}
