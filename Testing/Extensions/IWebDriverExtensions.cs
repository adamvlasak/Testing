using OpenQA.Selenium.Support.UI;
using System.IO;

namespace OpenQA.Selenium
{
    public enum FrontendFramework
    {
        jQuery,
        vanilla,
        angular,
        react
    }

    public static class IWebDriverExtensions
    {
        public static void Screenshot(this IWebDriver driver, string className, string methodName)
        {
            var path = "c:\\tmp";
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }

            screenshot.SaveAsFile($"{path}\\{System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")}_{className}_{methodName}.png", ScreenshotImageFormat.Png);
        }

        public static void WaitForReady(this IWebDriver driver, WebDriverWait wait, FrontendFramework fw)
        {
            var js = (IJavaScriptExecutor)driver;
            string script = string.Empty;

            switch (fw)
            {
                case FrontendFramework.jQuery:
                    script = "return window.jQuery != undefined && window.jQuery.active === 0;";
                    break;

                default:
                    script = "return document.querySelector('body') != undefined;";
                    break;
            }

            wait.Until(d =>
            {
                var isReady = (bool)js.ExecuteScript(script);
                return isReady;
            });
        }
    }
}