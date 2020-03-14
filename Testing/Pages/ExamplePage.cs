using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace Testing.Pages
{
    public class ExamplePage : BasePage
    {
        IWebElement title => _driver.FindElement(By.TagName("h1"));
        IWebElement paragraph => _driver.FindElement(By.TagName("p"));

        public ExamplePage(IWebDriver driver) : base(driver)
        {
        }

        public void Visit()
        {
            _driver.Navigate().GoToUrl("https://example.org");
        }

        public void Verify()
        {
            Assert.That(title.Displayed, Is.True);
            Assert.That(paragraph.Displayed, Is.True);
        }
    }
}