using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
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
            WaitForElement(context, by);
            return context.FindElement(by);
        }

        public static T FindElementWithWait<T>(this ISearchContext context, By by) where T : BaseComponent
        {
            return Activator.CreateInstance(typeof(T), new object[] { ResolveContext(context), FindElementWithWait(context, by) }) as T;
        }

        public static ReadOnlyCollection<IWebElement> FindWebElements(this ISearchContext context, By by)
        {
            return context.FindElements(by);
        }

        private static void WaitForElement(ISearchContext context, By by)
        {
            var wait = new WebDriverWait(ResolveContext(context), TimeSpan.FromSeconds(Configuration.DefaultTimeout));
            wait.Until(d => context.FindElement(by));
        }

        private static IWebDriver ResolveContext(ISearchContext context)
        {
            if (context is RemoteWebElement)
                return ((IWrapsDriver)context).WrappedDriver;
            else if (context is ISearchContext)
                return context as IWebDriver;
            else
                throw new ArgumentException("Unable to resolve context.");
        }
    }
}
