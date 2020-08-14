using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.ObjectModel;
using WebGoat.Components;
using WebGoat.Framework;

namespace WebGoat.Extensions
{
    public static class ISearchContextExtensions
    {
        public static IWebElement FindElementWithWait(this ISearchContext context, By by)
        {
            WaitForElementToBeDisplayed(context, by);
            return context.FindElement(by);
        }

        public static T FindElementWithWait<T>(this ISearchContext context, By by) where T : BaseComponent
        {
            return Activator.CreateInstance(typeof(T), new object[] { ConvertToWebDriver(context), FindElementWithWait(context, by) }) as T;
        }

        public static ReadOnlyCollection<IWebElement> FindWebElements(this ISearchContext context, By by)
        {
            return context.FindElements(by);
        }

        private static void WaitForElementToBeDisplayed(ISearchContext context, By by)
        {
            var wait = Factory.CreateWebDriverWait(ConvertToWebDriver(context));
            wait.Until(d => context.FindElement(by)?.Displayed == true);
        }

        private static IWebDriver ConvertToWebDriver(ISearchContext context)
        {
            return context is RemoteWebElement ? ((IWrapsDriver)context).WrappedDriver : context as IWebDriver;
        }
    }
}
