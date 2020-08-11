using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebGoat.Components
{
	public abstract class BaseComponent : IWrapsElement, IWrapsDriver
	{
        public IWebElement WrappedElement { get; }

		public IWebDriver WrappedDriver { get; }

        protected WebDriverWait Wait { get; }

        public BaseComponent(IWebDriver driver, WebDriverWait wait, IWebElement element)
        {
			if (element == null)
			{
				throw new ArgumentNullException(nameof(element), "element cannot be null");
			}

			WrappedDriver = driver;
			WrappedElement = element;
			Wait = wait;
		}
	}
}
