using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace WebGoat.Extensions
{
    public static class IWebDriverExtensions
    {
        public static string Screenshot(this IWebDriver driver, string path, string className, string methodName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            var fileName = $"{path}\\{System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}_{className}_{methodName}.png";

            screenshot.SaveAsFile($"{fileName}", ScreenshotImageFormat.Png);

            return fileName;
        }

        public static void WaitForReady(this IWebDriver driver, WebDriverWait wait)
        {
            var js = (IJavaScriptExecutor)driver;
            wait.Until(d =>
            {
                var isReady = (bool)js.ExecuteScript("return document.querySelector('section#container') != undefined;");
                return isReady;
            });
        }
    }
}
