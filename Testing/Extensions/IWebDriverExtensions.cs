using OpenQA.Selenium.Support.UI;

namespace OpenQA.Selenium
{
    public static class IWebDriverExtensions
    {
        public static void Screenshot(this IWebDriver driver)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"c:\\tmp\\{System.DateTime.Now.ToString("yyyy-dd-MM--HH-mm-ss")}.png", ScreenshotImageFormat.Png);
        }
    }
}
