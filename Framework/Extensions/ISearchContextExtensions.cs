using Framework.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace Framework.Extensions
{
    public static class ISearchContextExtensions
    {
        /// <summary>
        /// Finds the first OpenQA.Selenium.IWebElement using the given method.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="by"></param>
        /// <returns>The first matching OpenQA.Selenium.IWebElement on the current context.</returns>
        public static IWebElement FindElementWithWait(this ISearchContext context, By by)
        {
            WaitForIWebElement(context, by);
            return context.FindElement(by);
        }

        /// <summary>
        /// Waits until Element.Displayed == true.
        /// </summary>
        /// <param name="context">ISearchContext context</param>
        /// <param name="by">By locator</param>
        private static void WaitForIWebElement(ISearchContext context, By by)
        {
            var wait = Factory.CreateWebDriverWait(ConvertToWebDriver(context));
            wait.Until(_ => context.FindElement(by) is IWebElement);
        }

        /// <summary>
        /// There are 2 contexts: IWebElement and IWebDriver.
        /// </summary>
        /// <param name="context">ISearchContext context</param>
        /// <returns>IWebDriver</returns>
        private static IWebDriver ConvertToWebDriver(ISearchContext context)
        {
            return context is IWebElement ? ((IWrapsDriver)context).WrappedDriver : context as IWebDriver;
        }
    }
}
