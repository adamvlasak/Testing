using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using System;
using WebGoat.Components;
using WebGoat.Framework;

namespace WebGoat.Extensions
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
            WaitForElementToBeDisplayed(context, by);
            return context.FindElement(by);
        }

        /// <summary>
        /// Returns instance of component.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="context">ISearchContext context</param>
        /// <param name="by">By locator</param>
        /// <returns>Component of type T instance on the current context.</returns>
        public static T FindElementWithWait<T>(this ISearchContext context, By by) where T : BaseComponent
        {
            return Activator.CreateInstance(typeof(T), new object[] { ConvertToWebDriver(context), FindElementWithWait(context, by) }) as T;
        }

        /// <summary>
        /// Waits until Element.Displayed == true.
        /// </summary>
        /// <param name="context">ISearchContext context</param>
        /// <param name="by">By locator</param>
        private static void WaitForElementToBeDisplayed(ISearchContext context, By by)
        {
            var wait = Factory.CreateWebDriverWait(ConvertToWebDriver(context));
            wait.Until(d => context.FindElement(by)?.Displayed == true);
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
